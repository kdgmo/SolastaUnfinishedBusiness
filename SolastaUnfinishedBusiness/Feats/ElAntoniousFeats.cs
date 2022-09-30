﻿using System.Collections.Generic;
using JetBrains.Annotations;
using SolastaUnfinishedBusiness.Api;
using SolastaUnfinishedBusiness.Api.Extensions;
using SolastaUnfinishedBusiness.Builders;
using SolastaUnfinishedBusiness.Builders.Features;
using SolastaUnfinishedBusiness.CustomBehaviors;
using SolastaUnfinishedBusiness.CustomDefinitions;
using static RuleDefinitions;
using static SolastaUnfinishedBusiness.Api.DatabaseHelper.FeatureDefinitionAdditionalActions;

namespace SolastaUnfinishedBusiness.Feats;

internal static class ElAntoniousFeats
{
    public static void CreateFeats([NotNull] List<FeatDefinition> feats)
    {
        feats.Add(BuildFeatDualFlurry());
        feats.Add(BuildFeatTorchbearer());
    }

    private static FeatDefinition BuildFeatDualFlurry()
    {
        var conditionDualFlurryApply = ConditionDefinitionBuilder
            .Create("ConditionDualFlurryApply")
            .SetGuiPresentation(Category.Condition)
            .SetDuration(DurationType.Round, 0, false)
            .SetTurnOccurence(TurnOccurenceType.EndOfTurn)
            .SetPossessive(true)
            .SetSilent(Silent.WhenAddedOrRemoved)
            .SetConditionType(ConditionType.Beneficial)
            .AddToDB();

        var conditionDualFlurryGrant = ConditionDefinitionBuilder
            .Create("ConditionDualFlurryGrant")
            .SetGuiPresentation(Category.Condition)
            .SetDuration(DurationType.Round, 0, false)
            .SetTurnOccurence(TurnOccurenceType.EndOfTurn)
            .SetPossessive(true)
            .SetSilent(Silent.WhenAddedOrRemoved)
            .SetConditionType(ConditionType.Beneficial)
            .SetFeatures(
                FeatureDefinitionAdditionalActionBuilder
                    .Create(AdditionalActionSurgedMain, "AdditionalActionDualFlurry")
                    .SetGuiPresentation(Category.Feature, AdditionalActionSurgedMain.GuiPresentation.SpriteReference)
                    .SetActionType(ActionDefinitions.ActionType.Bonus)
                    .SetRestrictedActions(ActionDefinitions.Id.AttackOff)
                    .AddToDB())
            .AddToDB();

        void AfterOnAttackDamage(
            GameLocationCharacter attacker,
            GameLocationCharacter defender,
            ActionModifier attackModifier,
            [CanBeNull] RulesetAttackMode attackMode,
            bool rangedAttack,
            AdvantageType advantageType,
            List<EffectForm> actualEffectForms,
            RulesetEffect rulesetEffect,
            bool criticalHit,
            bool firstTarget)
        {
            if (rangedAttack || attackMode == null)
            {
                return;
            }

            var condition =
                attacker.RulesetCharacter.HasConditionOfType(conditionDualFlurryApply.Name)
                    ? conditionDualFlurryGrant
                    : conditionDualFlurryApply;

            var rulesetCondition = RulesetCondition.CreateActiveCondition(
                attacker.RulesetCharacter.Guid,
                condition, DurationType.Round, 0,
                TurnOccurenceType.EndOfTurn,
                attacker.RulesetCharacter.Guid,
                attacker.RulesetCharacter.CurrentFaction.Name);

            attacker.RulesetCharacter.AddConditionOfCategory(AttributeDefinitions.TagCombat, rulesetCondition);
        }

        return FeatDefinitionBuilder
            .Create("FeatDualFlurry")
            .SetGuiPresentation(Category.Feat)
            .SetFeatures(
                FeatureDefinitionOnAttackDamageEffectBuilder
                    .Create("OnAttackDamageEffectFeatDualFlurry")
                    .SetGuiPresentation("FeatDualFlurry", Category.Feat)
                    .SetOnAttackDamageDelegates(null, AfterOnAttackDamage)
                    .AddToDB())
            .AddToDB();
    }

    private static FeatDefinition BuildFeatTorchbearer()
    {
        var burnEffect = new EffectForm
        {
            formType = EffectForm.EffectFormType.Condition,
            ConditionForm = new ConditionForm
            {
                Operation = ConditionForm.ConditionOperation.Add,
                ConditionDefinition = DatabaseHelper.ConditionDefinitions.ConditionOnFire1D4
            }
        };

        var burnDescription = new EffectDescription()
            .Create(DatabaseHelper.SpellDefinitions.Fireball.EffectDescription)
            .SetCreatedByCharacter(true)
            .SetTargetSide(Side.Enemy)
            .SetTargetType(TargetType.Individuals)
            .SetTargetParameter(1)
            .SetRangeType(RangeType.Touch)
            .SetDurationType(DurationType.Round)
            .SetDurationParameter(3)
            .SetCanBePlacedOnCharacter(false)
            .SetHasSavingThrow(true)
            .SetSavingThrowAbility(AttributeDefinitions.Dexterity)
            .SetSavingThrowDifficultyAbility(AttributeDefinitions.Dexterity)
            .SetDifficultyClassComputation(EffectDifficultyClassComputation.AbilityScoreAndProficiency)
            .SetSpeedType(SpeedType.Instant)
            .SetEffectForms(burnEffect);

        var powerTorchbearer = FeatureDefinitionPowerBuilder
            .Create("PowerTorchbearer")
            .SetGuiPresentation(Category.Feature)
            .SetActivationTime(ActivationTime.BonusAction)
            .SetEffectDescription(burnDescription)
            .SetUsesFixed(1)
            .SetRechargeRate(RechargeRate.AtWill)
            .SetShowCasting(false)
            .SetCustomSubFeatures(new ValidatorPowerUse(ValidatorsCharacter.OffHandHasLightSource))
            .AddToDB();

        return FeatDefinitionBuilder
            .Create("FeatTorchbearer")
            .SetGuiPresentation(Category.Feat)
            .SetFeatures(powerTorchbearer)
            .AddToDB();
    }
}
