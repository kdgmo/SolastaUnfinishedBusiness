﻿using System;
using JetBrains.Annotations;
using SolastaUnfinishedBusiness.Api.GameExtensions;
using SolastaUnfinishedBusiness.CustomInterfaces;
using SolastaUnfinishedBusiness.CustomValidators;

namespace SolastaUnfinishedBusiness.CustomBehaviors;

internal class CanUseAttribute : IModifyWeaponAttackAttribute
{
    private readonly IsCharacterValidHandler[] _validators;
    private readonly string attribute;
    private readonly IsWeaponValidHandler isWeaponValid;

    internal CanUseAttribute(
        string attribute,
        IsWeaponValidHandler isWeaponValid = null,
        params IsCharacterValidHandler[] validators)
    {
        this.attribute = attribute;
        this.isWeaponValid = isWeaponValid;
        _validators = validators;
    }

    public void ModifyAttribute(RulesetCharacter character,
        [CanBeNull] RulesetAttackMode attackMode,
        RulesetItem weapon, bool canAddAbilityDamageBonus)
    {
        if (attackMode == null)
        {
            return;
        }

        if (!character.IsValid(_validators))
        {
            return;
        }

        if (isWeaponValid != null && !isWeaponValid(attackMode, weapon, character))
        {
            return;
        }

        var oldAttribute = attackMode.AbilityScore;
        var oldValue = character.TryGetAttributeValue(oldAttribute);
        oldValue = AttributeDefinitions.ComputeAbilityScoreModifier(oldValue);

        var newValue = character.TryGetAttributeValue(attribute);
        newValue = AttributeDefinitions.ComputeAbilityScoreModifier(newValue);

        if (newValue <= oldValue)
        {
            return;
        }

        attackMode.AbilityScore = attribute;
        attackMode.toHitBonus -= oldValue;
        attackMode.toHitBonus += newValue;

        var info = new RuleDefinitions.TrendInfo(newValue, RuleDefinitions.FeatureSourceType.AbilityScore,
            attackMode.AbilityScore, null);

        var i = attackMode.toHitBonusTrends
            .FindIndex(x => x.value == oldValue
                            && x.sourceType == RuleDefinitions.FeatureSourceType.AbilityScore
                            && x.sourceName == oldAttribute);

        if (i >= 0)
        {
            attackMode.toHitBonusTrends.RemoveAt(i);
            attackMode.toHitBonusTrends.Insert(i, info);
        }

        if (!canAddAbilityDamageBonus)
        {
            return;
        }

        var damage = attackMode.EffectDescription.FindFirstDamageForm();
        if (damage == null)
        {
            return;
        }

        damage.BonusDamage -= oldValue;
        damage.BonusDamage += newValue;

        i = damage.DamageBonusTrends
            .FindIndex(x => x.value == oldValue
                            && x.sourceType == RuleDefinitions.FeatureSourceType.AbilityScore
                            && x.sourceName == oldAttribute);
        if (i < 0)
        {
            return;
        }

        damage.DamageBonusTrends.RemoveAt(i);
        damage.DamageBonusTrends.Insert(i, info);
    }
}

internal abstract class ModifyWeaponAttackModeBase : IModifyWeaponAttackMode
{
    private readonly IsWeaponValidHandler isWeaponValid;
    private readonly string unicityTag;
    private readonly IsCharacterValidHandler[] validators;

    protected ModifyWeaponAttackModeBase(
        IsWeaponValidHandler isWeaponValid,
        params IsCharacterValidHandler[] validators) : this(isWeaponValid, null, validators)
    {
    }

    protected ModifyWeaponAttackModeBase(
        IsWeaponValidHandler isWeaponValid,
        string unicityTag,
        params IsCharacterValidHandler[] validators)
    {
        this.isWeaponValid = isWeaponValid;
        this.validators = validators;
        this.unicityTag = unicityTag;
    }

    public void ModifyAttackMode(RulesetCharacter character, [NotNull] RulesetAttackMode attackMode)
    {
        //Doing this check at the very start since this one is least computation intensive
        if (unicityTag != null && attackMode.AttackTags.Contains(unicityTag))
        {
            return;
        }

        if (!character.IsValid(validators))
        {
            return;
        }

        if (!isWeaponValid(attackMode, null, character))
        {
            return;
        }

        if (unicityTag != null)
        {
            attackMode.AttackTags.TryAdd(unicityTag);
        }

        TryModifyAttackMode(character, attackMode);
    }

    protected abstract void TryModifyAttackMode(
        [NotNull] RulesetCharacter character,
        [NotNull] RulesetAttackMode attackMode);
}

internal sealed class UpgradeWeaponDice : ModifyWeaponAttackModeBase
{
    private readonly GetWeaponDiceHandler getWeaponDice;

    internal UpgradeWeaponDice(
        GetWeaponDiceHandler getWeaponDice,
        IsWeaponValidHandler isWeaponValid,
        params IsCharacterValidHandler[] validators) : base(isWeaponValid, validators)
    {
        this.getWeaponDice = getWeaponDice;
    }

    protected override void TryModifyAttackMode(
        RulesetCharacter character,
        RulesetAttackMode attackMode)
    {
        var effectDescription = attackMode.EffectDescription;
        var damage = effectDescription?.FindFirstDamageForm();

        // below was interacting in a bad way with TWF and Spear Mastery so added an attack tag to polearm bonus only
        // || attackMode.actionType != ActionDefinitions.ActionType.Main)
        if (damage == null || attackMode.AttackTags.Contains("Polearm"))
        {
            return;
        }

        var (newNumber, newDie, newVersatileDie) = getWeaponDice(character, damage);

        var newDamage = RuleDefinitions.DieAverage(newDie) * newNumber;
        var oldDamage = RuleDefinitions.DieAverage(damage.DieType) * damage.DiceNumber;

        if (newDamage > oldDamage)
        {
            damage.DieType = newDie;
            damage.DiceNumber = newNumber;
        }

        newDamage = RuleDefinitions.DieAverage(newVersatileDie) * newNumber;
        oldDamage = RuleDefinitions.DieAverage(damage.VersatileDieType) * damage.DiceNumber;

        if (newDamage > oldDamage)
        {
            damage.VersatileDieType = newVersatileDie;
        }
    }

    internal delegate (int number, RuleDefinitions.DieType dieType, RuleDefinitions.DieType versatileDieType)
        GetWeaponDiceHandler(
            RulesetCharacter character,
            DamageForm damageForm);
}

internal sealed class AddTagToWeaponWeaponAttack : ModifyWeaponAttackModeBase
{
    private readonly string tag;

    internal AddTagToWeaponWeaponAttack(string tag, IsWeaponValidHandler isWeaponValid,
        params IsCharacterValidHandler[] validators) : base(isWeaponValid, validators)
    {
        this.tag = tag;
    }

    protected override void TryModifyAttackMode(
        RulesetCharacter character, RulesetAttackMode attackMode)
    {
        attackMode.AddAttackTagAsNeeded(tag);
    }
}

// internal class AddEffectToWeaponAttack : ModifyAttackModeForWeaponBase
// {
//     private readonly EffectForm effect;
//
//     internal AddEffectToWeaponAttack(EffectForm effect, IsWeaponValidHandler isWeaponValid,
//         params CharacterValidator[] validators) : base(isWeaponValid, validators)
//     {
//         this.effect = effect;
//     }
//
//     protected override void TryModifyAttackMode(RulesetCharacter character, [NotNull] RulesetAttackMode attackMode,
//         RulesetItem weapon)
//     {
//         attackMode.EffectDescription.AddEffectForms(effect);
//     }
// }

internal sealed class BumpWeaponWeaponAttackRangeToMax : ModifyWeaponAttackModeBase
{
    internal BumpWeaponWeaponAttackRangeToMax(IsWeaponValidHandler isWeaponValid,
        params IsCharacterValidHandler[] validators)
        : base(isWeaponValid, validators)
    {
    }

    protected override void TryModifyAttackMode(
        RulesetCharacter character, RulesetAttackMode attackMode)
    {
        attackMode.closeRange = attackMode.maxRange;
    }
}

internal sealed class IncreaseWeaponReach : ModifyWeaponAttackModeBase
{
    private readonly int bonus;

    internal IncreaseWeaponReach(int bonus, IsWeaponValidHandler isWeaponValid,
        params IsCharacterValidHandler[] validators) : this(bonus, isWeaponValid, null, validators)
    {
    }

    internal IncreaseWeaponReach(int bonus, IsWeaponValidHandler isWeaponValid, string unicityTag,
        params IsCharacterValidHandler[] validators) : base(isWeaponValid, unicityTag, validators)
    {
        this.bonus = bonus;
    }

    protected override void TryModifyAttackMode(
        RulesetCharacter character,
        RulesetAttackMode attackMode)
    {
        //maybe I'm paranoid, but I think I saw reach being 0 in some cases, hence the Math.Max
        attackMode.reachRange = Math.Max(attackMode.reachRange, 1) + bonus;
        attackMode.reach = true;
    }
}
