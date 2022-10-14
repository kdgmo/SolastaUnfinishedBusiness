// this file is manually maintained
// whenever you use a definition in DEBUG mode copy it over here
// goal is to increase mod boot time and reduce total payload size

namespace SolastaUnfinishedBusiness.Api;

internal static partial class DatabaseHelper
{
    internal static class AlignmentDefinitions
    {
        internal static AlignmentDefinition Neutral { get; } =
            GetDefinition<AlignmentDefinition>("Neutral");

    }

    internal static class FactionDefinitions
    {
        internal static FactionDefinition HostileMonsters { get; } =
            GetDefinition<FactionDefinition>("HostileMonsters");

        internal static FactionDefinition Party { get; } =
            GetDefinition<FactionDefinition>("Party");

    }

    internal static class EffectProxyDefinitions
    {
        internal static EffectProxyDefinition ProxyArcaneSword { get; } =
            GetDefinition<EffectProxyDefinition>("ProxyArcaneSword");

        internal static EffectProxyDefinition ProxyInsectPlague { get; } =
            GetDefinition<EffectProxyDefinition>("ProxyInsectPlague");

        internal static EffectProxyDefinition ProxySpikeGrowth { get; } =
            GetDefinition<EffectProxyDefinition>("ProxySpikeGrowth");
    }

    internal static class MonsterDefinitions
    {
        internal static MonsterDefinition Air_Elemental { get; } =
            GetDefinition<MonsterDefinition>("Air_Elemental");

        internal static MonsterDefinition Ape_MonsterDefinition { get; } =
            GetDefinition<MonsterDefinition>("Ape_MonsterDefinition");

        internal static MonsterDefinition BlackDragon_MasterOfNecromancy { get; } =
            GetDefinition<MonsterDefinition>("BlackDragon_MasterOfNecromancy");

        internal static MonsterDefinition BrownBear { get; } =
            GetDefinition<MonsterDefinition>("BrownBear");

        internal static MonsterDefinition ConjuredEightBeast_Wolf { get; } =
            GetDefinition<MonsterDefinition>("ConjuredEightBeast_Wolf");

        internal static MonsterDefinition ConjuredFourBeast_BadlandsSpider { get; } =
            GetDefinition<MonsterDefinition>("ConjuredFourBeast_BadlandsSpider");

        internal static MonsterDefinition ConjuredOneBeastTiger_Drake { get; } =
            GetDefinition<MonsterDefinition>("ConjuredOneBeastTiger_Drake");

        internal static MonsterDefinition ConjuredTwoBeast_Direwolf { get; } =
            GetDefinition<MonsterDefinition>("ConjuredTwoBeast_Direwolf");

        internal static MonsterDefinition Divine_Avatar { get; } =
            GetDefinition<MonsterDefinition>("Divine_Avatar");

        internal static MonsterDefinition Eagle_Matriarch { get; } =
            GetDefinition<MonsterDefinition>("Eagle_Matriarch");

        internal static MonsterDefinition Earth_Elemental { get; } =
            GetDefinition<MonsterDefinition>("Earth_Elemental");

        internal static MonsterDefinition Emperor_Laethar { get; } =
            GetDefinition<MonsterDefinition>("Emperor_Laethar");

        internal static MonsterDefinition FeyBear { get; } =
            GetDefinition<MonsterDefinition>("FeyBear");

        internal static MonsterDefinition FeyDriad { get; } =
            GetDefinition<MonsterDefinition>("FeyDriad");

        internal static MonsterDefinition FeyGiant_Eagle { get; } =
            GetDefinition<MonsterDefinition>("FeyGiant_Eagle");

        internal static MonsterDefinition FeyGiantApe { get; } =
            GetDefinition<MonsterDefinition>("FeyGiantApe");

        internal static MonsterDefinition FeyWolf { get; } =
            GetDefinition<MonsterDefinition>("FeyWolf");

        internal static MonsterDefinition Fire_Elemental { get; } =
            GetDefinition<MonsterDefinition>("Fire_Elemental");

        internal static MonsterDefinition Fire_Jester { get; } =
            GetDefinition<MonsterDefinition>("Fire_Jester");

        internal static MonsterDefinition Ghoul { get; } =
            GetDefinition<MonsterDefinition>("Ghoul");

        internal static MonsterDefinition Giant_Ape { get; } =
            GetDefinition<MonsterDefinition>("Giant_Ape");

        internal static MonsterDefinition GoldDragon_AerElai { get; } =
            GetDefinition<MonsterDefinition>("GoldDragon_AerElai");

        internal static MonsterDefinition Green_Hag { get; } =
            GetDefinition<MonsterDefinition>("Green_Hag");

        internal static MonsterDefinition GreenDragon_MasterOfConjuration { get; } =
            GetDefinition<MonsterDefinition>("GreenDragon_MasterOfConjuration");

        internal static MonsterDefinition InvisibleStalker { get; } =
            GetDefinition<MonsterDefinition>("InvisibleStalker");

        internal static MonsterDefinition Remorhaz { get; } =
            GetDefinition<MonsterDefinition>("Remorhaz");

        internal static MonsterDefinition SkarnGhoul { get; } =
            GetDefinition<MonsterDefinition>("SkarnGhoul");

        internal static MonsterDefinition Skeleton { get; } =
            GetDefinition<MonsterDefinition>("Skeleton");

        internal static MonsterDefinition Skeleton_Archer { get; } =
            GetDefinition<MonsterDefinition>("Skeleton_Archer");

        internal static MonsterDefinition Skeleton_Enforcer { get; } =
            GetDefinition<MonsterDefinition>("Skeleton_Enforcer");

        internal static MonsterDefinition Skeleton_Knight { get; } =
            GetDefinition<MonsterDefinition>("Skeleton_Knight");

        internal static MonsterDefinition Skeleton_Marksman { get; } =
            GetDefinition<MonsterDefinition>("Skeleton_Marksman");

        internal static MonsterDefinition Skeleton_Sorcerer { get; } =
            GetDefinition<MonsterDefinition>("Skeleton_Sorcerer");

        internal static MonsterDefinition Sorr_Akkath_Shikkath { get; } =
            GetDefinition<MonsterDefinition>("Sorr-Akkath_Shikkath");

        internal static MonsterDefinition Sorr_Akkath_Tshar_Boss { get; } =
            GetDefinition<MonsterDefinition>("Sorr-Akkath_Tshar_Boss");

        internal static MonsterDefinition Spider_Queen { get; } =
            GetDefinition<MonsterDefinition>("Spider_Queen");

        internal static MonsterDefinition SuperEgo_Servant_Hostile { get; } =
            GetDefinition<MonsterDefinition>("SuperEgo_Servant_Hostile");

        internal static MonsterDefinition WindSnake { get; } =
            GetDefinition<MonsterDefinition>("WindSnake");

        internal static MonsterDefinition Wolf { get; } =
            GetDefinition<MonsterDefinition>("Wolf");

        internal static MonsterDefinition Zombie { get; } =
            GetDefinition<MonsterDefinition>("Zombie");

    }

    internal static class ConditionDefinitions
    {
        internal static ConditionDefinition ConditionAcidSpit { get; } =
            GetDefinition<ConditionDefinition>("ConditionAcidSpit");

        internal static ConditionDefinition ConditionBaned { get; } =
            GetDefinition<ConditionDefinition>("ConditionBaned");

        internal static ConditionDefinition ConditionBarkskin { get; } =
            GetDefinition<ConditionDefinition>("ConditionBarkskin");

        internal static ConditionDefinition ConditionBearsEndurance { get; } =
            GetDefinition<ConditionDefinition>("ConditionBearsEndurance");

        internal static ConditionDefinition ConditionBleeding { get; } =
            GetDefinition<ConditionDefinition>("ConditionBleeding");

        internal static ConditionDefinition ConditionBlessed { get; } =
            GetDefinition<ConditionDefinition>("ConditionBlessed");

        internal static ConditionDefinition ConditionBlinded { get; } =
            GetDefinition<ConditionDefinition>("ConditionBlinded");

        internal static ConditionDefinition ConditionBranded { get; } =
            GetDefinition<ConditionDefinition>("ConditionBranded");

        internal static ConditionDefinition ConditionBullsStrength { get; } =
            GetDefinition<ConditionDefinition>("ConditionBullsStrength");

        internal static ConditionDefinition ConditionCalmedByCalmEmotionsAlly { get; } =
            GetDefinition<ConditionDefinition>("ConditionCalmedByCalmEmotionsAlly");

        internal static ConditionDefinition ConditionCharmed { get; } =
            GetDefinition<ConditionDefinition>("ConditionCharmed");

        internal static ConditionDefinition ConditionCharmedByHypnoticPattern { get; } =
            GetDefinition<ConditionDefinition>("ConditionCharmedByHypnoticPattern");

        internal static ConditionDefinition ConditionConjuredCreature { get; } =
            GetDefinition<ConditionDefinition>("ConditionConjuredCreature");

        internal static ConditionDefinition ConditionDarkness { get; } =
            GetDefinition<ConditionDefinition>("ConditionDarkness");

        internal static ConditionDefinition ConditionDarkvision { get; } =
            GetDefinition<ConditionDefinition>("ConditionDarkvision");

        internal static ConditionDefinition ConditionDazzled { get; } =
            GetDefinition<ConditionDefinition>("ConditionDazzled");

        internal static ConditionDefinition ConditionDead { get; } =
            GetDefinition<ConditionDefinition>("ConditionDead");

        internal static ConditionDefinition ConditionDummy { get; } =
            GetDefinition<ConditionDefinition>("ConditionDummy");

        internal static ConditionDefinition ConditionEncumbered { get; } =
            GetDefinition<ConditionDefinition>("ConditionEncumbered");

        internal static ConditionDefinition ConditionFlying12 { get; } =
            GetDefinition<ConditionDefinition>("ConditionFlying12");

        internal static ConditionDefinition ConditionFrightened { get; } =
            GetDefinition<ConditionDefinition>("ConditionFrightened");

        internal static ConditionDefinition ConditionFrightenedFear { get; } =
            GetDefinition<ConditionDefinition>("ConditionFrightenedFear");

        internal static ConditionDefinition ConditionFrightenedPhantasmalKiller { get; } =
            GetDefinition<ConditionDefinition>("ConditionFrightenedPhantasmalKiller");

        internal static ConditionDefinition ConditionHeraldOfBattle { get; } =
            GetDefinition<ConditionDefinition>("ConditionHeraldOfBattle");

        internal static ConditionDefinition ConditionHeroism { get; } =
            GetDefinition<ConditionDefinition>("ConditionHeroism");

        internal static ConditionDefinition ConditionHighlighted { get; } =
            GetDefinition<ConditionDefinition>("ConditionHighlighted");

        internal static ConditionDefinition ConditionHindered_By_Frost { get; } =
            GetDefinition<ConditionDefinition>("ConditionHindered_By_Frost");

        internal static ConditionDefinition ConditionIncapacitated { get; } =
            GetDefinition<ConditionDefinition>("ConditionIncapacitated");

        internal static ConditionDefinition ConditionInvisible { get; } =
            GetDefinition<ConditionDefinition>("ConditionInvisible");

        internal static ConditionDefinition ConditionInvisibleBase { get; } =
            GetDefinition<ConditionDefinition>("ConditionInvisibleBase");

        internal static ConditionDefinition ConditionInvisibleGreater { get; } =
            GetDefinition<ConditionDefinition>("ConditionInvisibleGreater");

        internal static ConditionDefinition ConditionJump { get; } =
            GetDefinition<ConditionDefinition>("ConditionJump");

        internal static ConditionDefinition ConditionKindredSpiritBondAC { get; } =
            GetDefinition<ConditionDefinition>("ConditionKindredSpiritBondAC");

        internal static ConditionDefinition ConditionKindredSpiritBondHP { get; } =
            GetDefinition<ConditionDefinition>("ConditionKindredSpiritBondHP");

        internal static ConditionDefinition ConditionKindredSpiritBondMeleeAttack { get; } =
            GetDefinition<ConditionDefinition>("ConditionKindredSpiritBondMeleeAttack");

        internal static ConditionDefinition ConditionKindredSpiritBondMeleeDamage { get; } =
            GetDefinition<ConditionDefinition>("ConditionKindredSpiritBondMeleeDamage");

        internal static ConditionDefinition ConditionKindredSpiritBondSavingThrows { get; } =
            GetDefinition<ConditionDefinition>("ConditionKindredSpiritBondSavingThrows");

        internal static ConditionDefinition ConditionLevitate { get; } =
            GetDefinition<ConditionDefinition>("ConditionLevitate");

        internal static ConditionDefinition ConditionLightSensitive { get; } =
            GetDefinition<ConditionDefinition>("ConditionLightSensitive");

        internal static ConditionDefinition ConditionMarkedByBrandingSmite { get; } =
            GetDefinition<ConditionDefinition>("ConditionMarkedByBrandingSmite");

        internal static ConditionDefinition ConditionOnFire1D4 { get; } =
            GetDefinition<ConditionDefinition>("ConditionOnFire1D4");

        internal static ConditionDefinition ConditionParalyzed { get; } =
            GetDefinition<ConditionDefinition>("ConditionParalyzed");

        internal static ConditionDefinition ConditionParalyzed_CrimsonSpiderVenom { get; } =
            GetDefinition<ConditionDefinition>("ConditionParalyzed_CrimsonSpiderVenom");

        internal static ConditionDefinition ConditionParalyzed_GhoulsCaress { get; } =
            GetDefinition<ConditionDefinition>("ConditionParalyzed_GhoulsCaress");

        internal static ConditionDefinition ConditionPoisoned { get; } =
            GetDefinition<ConditionDefinition>("ConditionPoisoned");

        internal static ConditionDefinition ConditionProne { get; } =
            GetDefinition<ConditionDefinition>("ConditionProne");

        internal static ConditionDefinition ConditionProtectedFromEnergyLightning { get; } =
            GetDefinition<ConditionDefinition>("ConditionProtectedFromEnergyLightning");

        internal static ConditionDefinition ConditionProtectedFromPoison { get; } =
            GetDefinition<ConditionDefinition>("ConditionProtectedFromPoison");

        internal static ConditionDefinition ConditionRaging { get; } =
            GetDefinition<ConditionDefinition>("ConditionRaging");

        internal static ConditionDefinition ConditionRestrained { get; } =
            GetDefinition<ConditionDefinition>("ConditionRestrained");

        internal static ConditionDefinition ConditionRevealedByDetectGoodOrEvil { get; } =
            GetDefinition<ConditionDefinition>("ConditionRevealedByDetectGoodOrEvil");

        internal static ConditionDefinition ConditionSeeInvisibility { get; } =
            GetDefinition<ConditionDefinition>("ConditionSeeInvisibility");

        internal static ConditionDefinition ConditionShocked { get; } =
            GetDefinition<ConditionDefinition>("ConditionShocked");

        internal static ConditionDefinition ConditionShielded { get; } =
            GetDefinition<ConditionDefinition>("ConditionShielded");

        internal static ConditionDefinition ConditionSorcererChildRiftDeflection { get; } =
            GetDefinition<ConditionDefinition>("ConditionSorcererChildRiftDeflection");

        internal static ConditionDefinition ConditionStoneResilience { get; } =
            GetDefinition<ConditionDefinition>("ConditionStoneResilience");

        internal static ConditionDefinition ConditionStunned { get; } =
            GetDefinition<ConditionDefinition>("ConditionStunned");

        internal static ConditionDefinition ConditionStunned_MutantApeSlam { get; } =
            GetDefinition<ConditionDefinition>("ConditionStunned_MutantApeSlam");

        internal static ConditionDefinition ConditionStunnedConjuredDeath { get; } =
            GetDefinition<ConditionDefinition>("ConditionStunnedConjuredDeath");

        internal static ConditionDefinition ConditionSurprised { get; } =
            GetDefinition<ConditionDefinition>("ConditionSurprised");

        internal static ConditionDefinition ConditionTrueStrike { get; } =
            GetDefinition<ConditionDefinition>("ConditionTrueStrike");

        internal static ConditionDefinition ConditionWildShapeSubstituteForm { get; } =
            GetDefinition<ConditionDefinition>("ConditionWildShapeSubstituteForm");
    }

    internal static class ArmorCategoryDefinitions
    {
        internal static ArmorCategoryDefinition HeavyArmorCategory { get; } =
            GetDefinition<ArmorCategoryDefinition>("HeavyArmorCategory");

        internal static ArmorCategoryDefinition LightArmorCategory { get; } =
            GetDefinition<ArmorCategoryDefinition>("LightArmorCategory");

        internal static ArmorCategoryDefinition ShieldCategory { get; } =
            GetDefinition<ArmorCategoryDefinition>("ShieldCategory");
    }

    internal static class CharacterBackgroundDefinitions
    {
        internal static CharacterBackgroundDefinition Academic { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Academic");

        internal static CharacterBackgroundDefinition Acolyte { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Acolyte");

        internal static CharacterBackgroundDefinition Aescetic_Background { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Aescetic_Background");

        internal static CharacterBackgroundDefinition Aristocrat { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Aristocrat");

        internal static CharacterBackgroundDefinition Artist_Background { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Artist_Background");

        internal static CharacterBackgroundDefinition Lawkeeper { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Lawkeeper");

        internal static CharacterBackgroundDefinition Lowlife { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Lowlife");

        internal static CharacterBackgroundDefinition Occultist_Background { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Occultist_Background");

        internal static CharacterBackgroundDefinition Philosopher { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Philosopher");

        internal static CharacterBackgroundDefinition SellSword { get; } =
            GetDefinition<CharacterBackgroundDefinition>("SellSword");

        internal static CharacterBackgroundDefinition Spy { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Spy");

        internal static CharacterBackgroundDefinition Wanderer { get; } =
            GetDefinition<CharacterBackgroundDefinition>("Wanderer");
    }

    internal static class CharacterClassDefinitions
    {
        internal static CharacterClassDefinition Barbarian { get; } =
            GetDefinition<CharacterClassDefinition>("Barbarian");

        internal static CharacterClassDefinition Bard { get; } =
            GetDefinition<CharacterClassDefinition>("Bard");

        internal static CharacterClassDefinition Cleric { get; } =
            GetDefinition<CharacterClassDefinition>("Cleric");

        internal static CharacterClassDefinition Druid { get; } =
            GetDefinition<CharacterClassDefinition>("Druid");

        internal static CharacterClassDefinition Fighter { get; } =
            GetDefinition<CharacterClassDefinition>("Fighter");

        internal static CharacterClassDefinition Monk { get; } =
            GetDefinition<CharacterClassDefinition>("Monk");

        internal static CharacterClassDefinition Paladin { get; } =
            GetDefinition<CharacterClassDefinition>("Paladin");

        internal static CharacterClassDefinition Ranger { get; } =
            GetDefinition<CharacterClassDefinition>("Ranger");

        internal static CharacterClassDefinition Rogue { get; } =
            GetDefinition<CharacterClassDefinition>("Rogue");

        internal static CharacterClassDefinition Sorcerer { get; } =
            GetDefinition<CharacterClassDefinition>("Sorcerer");

        internal static CharacterClassDefinition Warlock { get; } =
            GetDefinition<CharacterClassDefinition>("Warlock");

        internal static CharacterClassDefinition Wizard { get; } =
            GetDefinition<CharacterClassDefinition>("Wizard");

    }

    internal static class CharacterFamilyDefinitions
    {
        internal static CharacterFamilyDefinition Construct { get; } =
            GetDefinition<CharacterFamilyDefinition>("Construct");

        internal static CharacterFamilyDefinition Fey { get; } =
            GetDefinition<CharacterFamilyDefinition>("Fey");

        internal static CharacterFamilyDefinition Humanoid { get; } =
            GetDefinition<CharacterFamilyDefinition>("Humanoid");

        internal static CharacterFamilyDefinition Undead { get; } =
            GetDefinition<CharacterFamilyDefinition>("Undead");

    }

    internal static class CharacterRaceDefinitions
    {
        internal static CharacterRaceDefinition Dwarf { get; } =
            GetDefinition<CharacterRaceDefinition>("Dwarf");

        internal static CharacterRaceDefinition DwarfHill { get; } =
            GetDefinition<CharacterRaceDefinition>("DwarfHill");

        internal static CharacterRaceDefinition DwarfSnow { get; } =
            GetDefinition<CharacterRaceDefinition>("DwarfSnow");

        internal static CharacterRaceDefinition Elf { get; } =
            GetDefinition<CharacterRaceDefinition>("Elf");

        internal static CharacterRaceDefinition ElfHigh { get; } =
            GetDefinition<CharacterRaceDefinition>("ElfHigh");

        internal static CharacterRaceDefinition ElfSylvan { get; } =
            GetDefinition<CharacterRaceDefinition>("ElfSylvan");

        internal static CharacterRaceDefinition HalfElf { get; } =
            GetDefinition<CharacterRaceDefinition>("HalfElf");

        internal static CharacterRaceDefinition Human { get; } =
            GetDefinition<CharacterRaceDefinition>("Human");

    }

    internal static class CharacterSizeDefinitions
    {
        internal static CharacterSizeDefinition Gargantuan { get; } =
            GetDefinition<CharacterSizeDefinition>("Gargantuan");

        internal static CharacterSizeDefinition Huge { get; } =
            GetDefinition<CharacterSizeDefinition>("Huge");

        internal static CharacterSizeDefinition Large { get; } =
            GetDefinition<CharacterSizeDefinition>("Large");

        internal static CharacterSizeDefinition Medium { get; } =
            GetDefinition<CharacterSizeDefinition>("Medium");

        internal static CharacterSizeDefinition Small { get; } =
            GetDefinition<CharacterSizeDefinition>("Small");

        internal static CharacterSizeDefinition Tiny { get; } =
            GetDefinition<CharacterSizeDefinition>("Tiny");

    }

    internal static class CharacterSubclassDefinitions
    {
        internal static CharacterSubclassDefinition DomainBattle { get; } =
            GetDefinition<CharacterSubclassDefinition>("DomainBattle");

        //internal static CharacterSubclassDefinition DomainElementalCold { get; } =GetDefinition<CharacterSubclassDefinition>("DomainElementalCold");

        internal static CharacterSubclassDefinition DomainElementalFire { get; } =
            GetDefinition<CharacterSubclassDefinition>("DomainElementalFire");

        //internal static CharacterSubclassDefinition DomainElementalLighting { get; } =GetDefinition<CharacterSubclassDefinition>("DomainElementalLighting");

        internal static CharacterSubclassDefinition DomainInsight { get; } =
            GetDefinition<CharacterSubclassDefinition>("DomainInsight");

        //internal static CharacterSubclassDefinition DomainLaw { get; } =GetDefinition<CharacterSubclassDefinition>("DomainLaw");

        internal static CharacterSubclassDefinition DomainLife { get; } =
            GetDefinition<CharacterSubclassDefinition>("DomainLife");

        internal static CharacterSubclassDefinition DomainMischief { get; } =
            GetDefinition<CharacterSubclassDefinition>("DomainMischief");

        //internal static CharacterSubclassDefinition DomainOblivion { get; } =GetDefinition<CharacterSubclassDefinition>("DomainOblivion");

        internal static CharacterSubclassDefinition DomainSun { get; } =
            GetDefinition<CharacterSubclassDefinition>("DomainSun");

        internal static CharacterSubclassDefinition MartialChampion { get; } =
            GetDefinition<CharacterSubclassDefinition>("MartialChampion");

        internal static CharacterSubclassDefinition MartialCommander { get; } =
            GetDefinition<CharacterSubclassDefinition>("MartialCommander");

        internal static CharacterSubclassDefinition MartialMountaineer { get; } =
            GetDefinition<CharacterSubclassDefinition>("MartialMountaineer");

        internal static CharacterSubclassDefinition MartialSpellblade { get; } =
            GetDefinition<CharacterSubclassDefinition>("MartialSpellblade");

        internal static CharacterSubclassDefinition OathOfDevotion { get; } =
            GetDefinition<CharacterSubclassDefinition>("OathOfDevotion");

        internal static CharacterSubclassDefinition OathOfJugement { get; } =
            GetDefinition<CharacterSubclassDefinition>("OathOfJugement");

        internal static CharacterSubclassDefinition OathOfTheMotherland { get; } =
            GetDefinition<CharacterSubclassDefinition>("OathOfTheMotherland");

        internal static CharacterSubclassDefinition PathBerserker { get; } =
            GetDefinition<CharacterSubclassDefinition>("PathBerserker");

        internal static CharacterSubclassDefinition PathMagebane { get; } =
            GetDefinition<CharacterSubclassDefinition>("PathMagebane");

        internal static CharacterSubclassDefinition RangerMarksman { get; } =
            GetDefinition<CharacterSubclassDefinition>("RangerMarksman");

        internal static CharacterSubclassDefinition RangerShadowTamer { get; } =
            GetDefinition<CharacterSubclassDefinition>("RangerShadowTamer");

        internal static CharacterSubclassDefinition RangerSwiftBlade { get; } =
            GetDefinition<CharacterSubclassDefinition>("RangerSwiftBlade");

        internal static CharacterSubclassDefinition RoguishDarkweaver { get; } =
            GetDefinition<CharacterSubclassDefinition>("RoguishDarkweaver");

        internal static CharacterSubclassDefinition RoguishShadowCaster { get; } =
            GetDefinition<CharacterSubclassDefinition>("RoguishShadowCaster");

        internal static CharacterSubclassDefinition SorcerousChildRift { get; } =
            GetDefinition<CharacterSubclassDefinition>("SorcerousChildRift");

        internal static CharacterSubclassDefinition SorcerousDraconicBloodline { get; } =
            GetDefinition<CharacterSubclassDefinition>("SorcerousDraconicBloodline");

        internal static CharacterSubclassDefinition SorcerousHauntedSoul { get; } =
            GetDefinition<CharacterSubclassDefinition>("SorcerousHauntedSoul");

        internal static CharacterSubclassDefinition SorcerousManaPainter { get; } =
            GetDefinition<CharacterSubclassDefinition>("SorcerousManaPainter");

        internal static CharacterSubclassDefinition TraditionGreenmage { get; } =
            GetDefinition<CharacterSubclassDefinition>("TraditionGreenmage");

        internal static CharacterSubclassDefinition TraditionLight { get; } =
            GetDefinition<CharacterSubclassDefinition>("TraditionLight");

        internal static CharacterSubclassDefinition TraditionLoremaster { get; } =
            GetDefinition<CharacterSubclassDefinition>("TraditionLoremaster");
    }

    internal static class DamageDefinitions
    {
        internal static DamageDefinition DamageBludgeoning { get; } =
            GetDefinition<DamageDefinition>("DamageBludgeoning");

        internal static DamageDefinition DamageCold { get; } =
            GetDefinition<DamageDefinition>("DamageCold");

        internal static DamageDefinition DamageFire { get; } =
            GetDefinition<DamageDefinition>("DamageFire");

        internal static DamageDefinition DamageThunder { get; } =
            GetDefinition<DamageDefinition>("DamageThunder");

    }

    internal static class FactionStatusDefinitions
    {
        internal static FactionStatusDefinition Alliance { get; } =
            GetDefinition<FactionStatusDefinition>("Alliance");

        internal static FactionStatusDefinition Brotherhood { get; } =
            GetDefinition<FactionStatusDefinition>("Brotherhood");

        internal static FactionStatusDefinition Indifference { get; } =
            GetDefinition<FactionStatusDefinition>("Indifference");

        internal static FactionStatusDefinition Sympathy { get; } =
            GetDefinition<FactionStatusDefinition>("Sympathy");

    }

    internal static class FeatDefinitions
    {
        internal static FeatDefinition BurningTouch { get; } =
            GetDefinition<FeatDefinition>("BurningTouch");

        internal static FeatDefinition Creed_Of_Arun { get; } =
            GetDefinition<FeatDefinition>("Creed_Of_Arun");

        internal static FeatDefinition Creed_Of_Einar { get; } =
            GetDefinition<FeatDefinition>("Creed_Of_Einar");

        internal static FeatDefinition Creed_Of_Maraike { get; } =
            GetDefinition<FeatDefinition>("Creed_Of_Maraike");

        internal static FeatDefinition Creed_Of_Misaye { get; } =
            GetDefinition<FeatDefinition>("Creed_Of_Misaye");

        internal static FeatDefinition Creed_Of_Pakri { get; } =
            GetDefinition<FeatDefinition>("Creed_Of_Pakri");

        internal static FeatDefinition Creed_Of_Solasta { get; } =
            GetDefinition<FeatDefinition>("Creed_Of_Solasta");

        internal static FeatDefinition ElectrifyingTouch { get; } =
            GetDefinition<FeatDefinition>("ElectrifyingTouch");

        internal static FeatDefinition FocusedSleeper { get; } =
            GetDefinition<FeatDefinition>("FocusedSleeper");

        internal static FeatDefinition IcyTouch { get; } =
            GetDefinition<FeatDefinition>("IcyTouch");

        internal static FeatDefinition Lockbreaker { get; } =
            GetDefinition<FeatDefinition>("Lockbreaker");

        internal static FeatDefinition MeltingTouch { get; } =
            GetDefinition<FeatDefinition>("MeltingTouch");

        internal static FeatDefinition ToxicTouch { get; } =
            GetDefinition<FeatDefinition>("ToxicTouch");

    }

    internal static class FeatureDefinitionAbilityCheckAffinitys
    {
        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityConditionBearsEndurance { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityConditionBearsEndurance");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityConditionBullsStrength { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityConditionBullsStrength");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityConditionCatsGrace { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityConditionCatsGrace");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityConditionEaglesSplendor { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityConditionEaglesSplendor");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityConditionFoxsCunning { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityConditionFoxsCunning");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityConditionOwlsWisdom { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityConditionOwlsWisdom");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityFeatLockbreaker { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityFeatLockbreaker");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityIslandHalflingAcrobatics { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityIslandHalflingAcrobatics");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityKeenHearing { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityKeenHearing");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityKeenSight { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityKeenSight");

        internal static FeatureDefinitionAbilityCheckAffinity AbilityCheckAffinityStealthDisadvantage { get; } =
            GetDefinition<FeatureDefinitionAbilityCheckAffinity>("AbilityCheckAffinityStealthDisadvantage");
    }

    internal static class FeatureDefinitionActionAffinitys
    {
        internal static FeatureDefinitionActionAffinity ActionAffinityBarbarianRecklessAttack { get; } =
            GetDefinition<FeatureDefinitionActionAffinity>("ActionAffinityBarbarianRecklessAttack");

        internal static FeatureDefinitionActionAffinity ActionAffinityConditionRestrained { get; } =
            GetDefinition<FeatureDefinitionActionAffinity>("ActionAffinityConditionRestrained");

        internal static FeatureDefinitionActionAffinity ActionAffinityConditionShocked { get; } =
            GetDefinition<FeatureDefinitionActionAffinity>("ActionAffinityConditionShocked");

        internal static FeatureDefinitionActionAffinity ActionAffinityFightingStyleProtection { get; } =
            GetDefinition<FeatureDefinitionActionAffinity>("ActionAffinityFightingStyleProtection");

        internal static FeatureDefinitionActionAffinity ActionAffinityMarksmanReactionShot { get; } =
            GetDefinition<FeatureDefinitionActionAffinity>("ActionAffinityMarksmanReactionShot");

        internal static FeatureDefinitionActionAffinity ActionAffinityMountaineerShieldCharge { get; } =
            GetDefinition<FeatureDefinitionActionAffinity>("ActionAffinityMountaineerShieldCharge");

        internal static FeatureDefinitionActionAffinity ActionAffinitySorcererMetamagicToggle { get; } =
            GetDefinition<FeatureDefinitionActionAffinity>("ActionAffinitySorcererMetamagicToggle");

        internal static FeatureDefinitionActionAffinity ActionAffinityTraditionGreenMageLeafScales { get; } =
            GetDefinition<FeatureDefinitionActionAffinity>("ActionAffinityTraditionGreenMageLeafScales");
    }

    internal static class FeatureDefinitionAdditionalActions
    {
        //internal static FeatureDefinitionAdditionalAction AdditionalActionHunterHordeBreaker { get; } =GetDefinition<FeatureDefinitionAdditionalAction>("AdditionalActionHunterHordeBreaker");

        internal static FeatureDefinitionAdditionalAction AdditionalActionSurgedMain { get; } =
            GetDefinition<FeatureDefinitionAdditionalAction>("AdditionalActionSurgedMain");
    }

    internal static class FeatureDefinitionAdditionalDamages
    {
        internal static FeatureDefinitionAdditionalDamage AdditionalDamageBrandingSmite { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageBrandingSmite");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageCircleBalanceColdEmbrace { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageCircleBalanceColdEmbrace");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageDomainLifeDivineStrike { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageDomainLifeDivineStrike");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageHuntersMark { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageHuntersMark");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamagePaladinDivineSmite { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamagePaladinDivineSmite");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyAberration { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyAberration");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyBeast { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyBeast");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyCelestial { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyCelestial");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyConstruct { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyConstruct");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyDragon { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyDragon");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyElemental { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyElemental");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyFey { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyFey");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyFiend { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyFiend");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyGiant { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyGiant");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyMonstrosity { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyMonstrosity");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyOoze { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyOoze");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyPlant { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyPlant");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRangerFavoredEnemyUndead { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRangerFavoredEnemyUndead");

        internal static FeatureDefinitionAdditionalDamage AdditionalDamageRogueSneakAttack { get; } =
            GetDefinition<FeatureDefinitionAdditionalDamage>("AdditionalDamageRogueSneakAttack");
    }

    internal static class FeatureDefinitionAttackModifiers
    {
        internal static FeatureDefinitionAttackModifier AttackModifierBerserkerFrenzy { get; } =
            GetDefinition<FeatureDefinitionAttackModifier>("AttackModifierBerserkerFrenzy");

        internal static FeatureDefinitionAttackModifier AttackModifierMagicWeapon { get; } =
            GetDefinition<FeatureDefinitionAttackModifier>("AttackModifierMagicWeapon");

        internal static FeatureDefinitionAttackModifier AttackModifierMagicWeapon3 { get; } =
            GetDefinition<FeatureDefinitionAttackModifier>("AttackModifierMagicWeapon3");

        internal static FeatureDefinitionAttackModifier AttackModifierWeaponPlus1 { get; } =
            GetDefinition<FeatureDefinitionAttackModifier>("AttackModifierWeapon+1");

        internal static FeatureDefinitionAttackModifier AttackModifierWeaponPlus1AT { get; } =
            GetDefinition<FeatureDefinitionAttackModifier>("AttackModifierWeapon+1AT");

        internal static FeatureDefinitionAttackModifier AttackModifierWeaponPlus2 { get; } =
            GetDefinition<FeatureDefinitionAttackModifier>("AttackModifierWeapon+2");
    }

    internal static class FeatureDefinitionAttributeModifiers
    {
        internal static FeatureDefinitionAttributeModifier AttributeModifierBarbarianUnarmoredDefense { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierBarbarianUnarmoredDefense");

        internal static FeatureDefinitionAttributeModifier AttributeModifierBarkskin { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierBarkskin");

        internal static FeatureDefinitionAttributeModifier AttributeModifierCreed_Of_Einar { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierCreed_Of_Einar");

        internal static FeatureDefinitionAttributeModifier AttributeModifierCreed_Of_Maraike { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierCreed_Of_Maraike");

        internal static FeatureDefinitionAttributeModifier AttributeModifierCreed_Of_Misaye { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierCreed_Of_Misaye");

        internal static FeatureDefinitionAttributeModifier AttributeModifierCreed_Of_Pakri { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierCreed_Of_Pakri");

        internal static FeatureDefinitionAttributeModifier AttributeModifierCreed_Of_Solasta { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierCreed_Of_Solasta");

        internal static FeatureDefinitionAttributeModifier AttributeModifierDwarfHillToughness { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierDwarfHillToughness");

        internal static FeatureDefinitionAttributeModifier AttributeModifierFighterExtraAttack { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierFighterExtraAttack");

        internal static FeatureDefinitionAttributeModifier AttributeModifierHumanAbilityScoreIncrease { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierHumanAbilityScoreIncrease");

        internal static FeatureDefinitionAttributeModifier AttributeModifierMageArmor { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierMageArmor");

        internal static FeatureDefinitionAttributeModifier AttributeModifierMartialChampionImprovedCritical { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierMartialChampionImprovedCritical");

        internal static FeatureDefinitionAttributeModifier AttributeModifierMartialChampionSuperiorCritical { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierMartialChampionSuperiorCritical");

        internal static FeatureDefinitionAttributeModifier AttributeModifierMonkUnarmoredDefense { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierMonkUnarmoredDefense");

        internal static FeatureDefinitionAttributeModifier AttributeModifierPaladinHealingPoolBase { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierPaladinHealingPoolBase");

        internal static FeatureDefinitionAttributeModifier AttributeModifierPaladinHealingPoolMultiplier { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierPaladinHealingPoolMultiplier");

        internal static FeatureDefinitionAttributeModifier AttributeModifierSorcererDraconicResilienceAC { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierSorcererDraconicResilienceAC");

        internal static FeatureDefinitionAttributeModifier AttributeModifierSorcererSorceryPointsBase { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierSorcererSorceryPointsBase");

        internal static FeatureDefinitionAttributeModifier AttributeModifierSwiftBladeBladeDance { get; } =
            GetDefinition<FeatureDefinitionAttributeModifier>("AttributeModifierSwiftBladeBladeDance");
    }

    // internal static class FeatureDefinitionAutoPreparedSpellss
    // {
    //     internal static FeatureDefinitionAutoPreparedSpells AutoPreparedSpellsOathOfDevotion { get; } =GetDefinition<FeatureDefinitionAutoPreparedSpells>("AutoPreparedSpellsOathOfDevotion");

    //     internal static FeatureDefinitionAutoPreparedSpells AutoPreparedSpellsOathOfMotherland { get; } =GetDefinition<FeatureDefinitionAutoPreparedSpells>("AutoPreparedSpellsOathOfMotherland");

    //     internal static FeatureDefinitionAutoPreparedSpells AutoPreparedSpellsOathOfTirmar { get; } =GetDefinition<FeatureDefinitionAutoPreparedSpells>("AutoPreparedSpellsOathOfTirmar");

    // }
    internal static class FeatureDefinitionCastSpells
    {
        internal static FeatureDefinitionCastSpell CastSpellBard { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellBard");

        internal static FeatureDefinitionCastSpell CastSpellCleric { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellCleric");

        internal static FeatureDefinitionCastSpell CastSpellDruid { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellDruid");

        internal static FeatureDefinitionCastSpell CastSpellElfHigh { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellElfHigh");

        internal static FeatureDefinitionCastSpell CastSpellMartialSpellBlade { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellMartialSpellBlade");

        internal static FeatureDefinitionCastSpell CastSpellPaladin { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellPaladin");

        internal static FeatureDefinitionCastSpell CastSpellRanger { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellRanger");

        internal static FeatureDefinitionCastSpell CastSpellShadowcaster { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellShadowcaster");

        internal static FeatureDefinitionCastSpell CastSpellSorcerer { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellSorcerer");

        internal static FeatureDefinitionCastSpell CastSpellTraditionLight { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellTraditionLight");

        internal static FeatureDefinitionCastSpell CastSpellWarlock { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellWarlock");

        internal static FeatureDefinitionCastSpell CastSpellWizard { get; } =
            GetDefinition<FeatureDefinitionCastSpell>("CastSpellWizard");
    }

    internal static class FeatureDefinitionCharacterPresentations
    {
        internal static FeatureDefinitionCharacterPresentation CharacterPresentationBeltOfDwarvenKind { get; } =
            GetDefinition<FeatureDefinitionCharacterPresentation>("CharacterPresentationBeltOfDwarvenKind");
    }

    internal static class FeatureDefinitionCombatAffinitys
    {
        internal static FeatureDefinitionCombatAffinity CombatAffinityBlessed { get; } =
            GetDefinition<FeatureDefinitionCombatAffinity>("CombatAffinityBlessed");

        internal static FeatureDefinitionCombatAffinity CombatAffinityDisengaging { get; } =
            GetDefinition<FeatureDefinitionCombatAffinity>("CombatAffinityDisengaging");

        internal static FeatureDefinitionCombatAffinity CombatAffinityFlyby { get; } =
            GetDefinition<FeatureDefinitionCombatAffinity>("CombatAffinityFlyby");

        internal static FeatureDefinitionCombatAffinity CombatAffinityPoisoned { get; } =
            GetDefinition<FeatureDefinitionCombatAffinity>("CombatAffinityPoisoned");

        internal static FeatureDefinitionCombatAffinity CombatAffinityProtectedFromEvil { get; } =
            GetDefinition<FeatureDefinitionCombatAffinity>("CombatAffinityProtectedFromEvil");

        internal static FeatureDefinitionCombatAffinity CombatAffinityReckless { get; } =
            GetDefinition<FeatureDefinitionCombatAffinity>("CombatAffinityReckless");

        internal static FeatureDefinitionCombatAffinity CombatAffinitySensitiveToLight { get; } =
            GetDefinition<FeatureDefinitionCombatAffinity>("CombatAffinitySensitiveToLight");

        internal static FeatureDefinitionCombatAffinity CombatAffinityStealthy { get; } =
            GetDefinition<FeatureDefinitionCombatAffinity>("CombatAffinityStealthy");
    }

    internal static class FeatureDefinitionConditionAffinitys
    {
        internal static FeatureDefinitionConditionAffinity ConditionAffinityCalmEmotionCharmedImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityCalmEmotionCharmedImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityCharmImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityCharmImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityCharmImmunityHypnoticPattern { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityCharmImmunityHypnoticPattern");

        internal static FeatureDefinitionConditionAffinity
            ConditionAffinityElfFeyAncestryCharmedByHypnoticPattern { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>(
                "ConditionAffinityElfFeyAncestryCharmedByHypnoticPattern");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityCircleLandNaturesWardCharmed { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityCircleLandNaturesWardCharmed");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityCircleLandNaturesWardFrightened { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityCircleLandNaturesWardFrightened");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityElfFeyAncestryCharm { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityElfFeyAncestryCharm");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityExhaustionImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityExhaustionImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityFrightenedImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityFrightenedImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityGrappledImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityGrappledImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityHalflingBrave { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityHalflingBrave");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityHinderedByFrostImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityHinderedByFrostImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityParalyzedmmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityParalyzedmmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityPetrifiedImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityPetrifiedImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityPoisonImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityPoisonImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityProneImmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityProneImmunity");

        internal static FeatureDefinitionConditionAffinity ConditionAffinityRestrainedmmunity { get; } =
            GetDefinition<FeatureDefinitionConditionAffinity>("ConditionAffinityRestrainedmmunity");
    }

    internal static class FeatureDefinitionDamageAffinitys
    {
        internal static FeatureDefinitionDamageAffinity DamageAffinityAcidResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityAcidResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityBludgeoningImmunity { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityBludgeoningImmunity");

        internal static FeatureDefinitionDamageAffinity DamageAffinityBludgeoningResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityBludgeoningResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityColdImmunity { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityColdImmunity");

        internal static FeatureDefinitionDamageAffinity DamageAffinityColdResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityColdResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityFireImmunity { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityFireImmunity");

        internal static FeatureDefinitionDamageAffinity DamageAffinityFireResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityFireResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityHalfOrcRelentlessEndurance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityHalfOrcRelentlessEndurance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityLightningResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityLightningResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityNecroticImmunity { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityNecroticImmunity");

        internal static FeatureDefinitionDamageAffinity DamageAffinityNecroticResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityNecroticResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityPiercingResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityPiercingResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityPoisonImmunity { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityPoisonImmunity");

        internal static FeatureDefinitionDamageAffinity DamageAffinityPoisonResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityPoisonResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityPsychicImmunity { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityPsychicImmunity");

        internal static FeatureDefinitionDamageAffinity DamageAffinityRadiantResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityRadiantResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinitySlashingResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinitySlashingResistance");

        internal static FeatureDefinitionDamageAffinity DamageAffinityThunderImmunity { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityThunderImmunity");

        internal static FeatureDefinitionDamageAffinity DamageAffinityThunderResistance { get; } =
            GetDefinition<FeatureDefinitionDamageAffinity>("DamageAffinityThunderResistance");
    }

    internal static class FeatureDefinitionDieRollModifiers
    {
        internal static FeatureDefinitionDieRollModifier DieRollModifierEmpoweredSpell { get; } =
            GetDefinition<FeatureDefinitionDieRollModifier>("DieRollModifierEmpoweredSpell");
    }

    internal static class FeatureDefinitionEquipmentAffinitys
    {
        internal static FeatureDefinitionEquipmentAffinity EquipmentAffinityFeatHauler { get; } =
            GetDefinition<FeatureDefinitionEquipmentAffinity>("EquipmentAffinityFeatHauler");
    }

    internal static class FeatureDefinitionFeatureSets
    {
        internal static FeatureDefinitionFeatureSet FeatureSetAbilityScoreChoice { get; } =
            GetDefinition<FeatureDefinitionFeatureSet>("FeatureSetAbilityScoreChoice");

        internal static FeatureDefinitionFeatureSet FeatureSetChampionRemarkableAthlete { get; } =
            GetDefinition<FeatureDefinitionFeatureSet>("FeatureSetChampionRemarkableAthlete");

        internal static FeatureDefinitionFeatureSet FeatureSetDragonbornBreathWeapon { get; } =
            GetDefinition<FeatureDefinitionFeatureSet>("FeatureSetDragonbornBreathWeapon");

        internal static FeatureDefinitionFeatureSet FeatureSetElfFeyAncestry { get; } =
            GetDefinition<FeatureDefinitionFeatureSet>("FeatureSetElfFeyAncestry");

        internal static FeatureDefinitionFeatureSet FeatureSetElfHighLanguages { get; } =
            GetDefinition<FeatureDefinitionFeatureSet>("FeatureSetElfHighLanguages");

        internal static FeatureDefinitionFeatureSet FeatureSetGreenmageWardenOfTheForest { get; } =
            GetDefinition<FeatureDefinitionFeatureSet>("FeatureSetGreenmageWardenOfTheForest");

        internal static FeatureDefinitionFeatureSet FeatureSetSorcererDraconicChoice { get; } =
            GetDefinition<FeatureDefinitionFeatureSet>("FeatureSetSorcererDraconicChoice");
    }

    internal static class FeatureDefinitionFightingStyleChoices
    {
        internal static FeatureDefinitionFightingStyleChoice FightingStyleChampionAdditional { get; } =
            GetDefinition<FeatureDefinitionFightingStyleChoice>("FightingStyleChampionAdditional");

        internal static FeatureDefinitionFightingStyleChoice FightingStyleFighter { get; } =
            GetDefinition<FeatureDefinitionFightingStyleChoice>("FightingStyleFighter");

        internal static FeatureDefinitionFightingStyleChoice FightingStylePaladin { get; } =
            GetDefinition<FeatureDefinitionFightingStyleChoice>("FightingStylePaladin");

        internal static FeatureDefinitionFightingStyleChoice FightingStyleRanger { get; } =
            GetDefinition<FeatureDefinitionFightingStyleChoice>("FightingStyleRanger");
    }

    internal static class FeatureDefinitionMagicAffinitys
    {
        internal static FeatureDefinitionMagicAffinity MagicAffinityBattleMagic { get; } =
            GetDefinition<FeatureDefinitionMagicAffinity>("MagicAffinityBattleMagic");

        internal static FeatureDefinitionMagicAffinity MagicAffinityGreenmageGreenMagicList { get; } =
            GetDefinition<FeatureDefinitionMagicAffinity>("MagicAffinityGreenmageGreenMagicList");
    }

    internal static class FeatureDefinitionMovementAffinitys
    {
        internal static FeatureDefinitionMovementAffinity MovementAffinityBarbarianFastMovement { get; } =
            GetDefinition<FeatureDefinitionMovementAffinity>("MovementAffinityBarbarianFastMovement");

        internal static FeatureDefinitionMovementAffinity MovementAffinityConditionRestrained { get; } =
            GetDefinition<FeatureDefinitionMovementAffinity>("MovementAffinityConditionRestrained");

        internal static FeatureDefinitionMovementAffinity MovementAffinityConditionLevitate { get; } =
            GetDefinition<FeatureDefinitionMovementAffinity>("MovementAffinityConditionLevitate");

        internal static FeatureDefinitionMovementAffinity MovementAffinityNoClimb { get; } =
            GetDefinition<FeatureDefinitionMovementAffinity>("MovementAffinityNoClimb");

        internal static FeatureDefinitionMovementAffinity MovementAffinityNoSpecialMoves { get; } =
            GetDefinition<FeatureDefinitionMovementAffinity>("MovementAffinityNoSpecialMoves");
    }

    internal static class FeatureDefinitionMoveModes
    {
        internal static FeatureDefinitionMoveMode MoveModeFly10 { get; } =
            GetDefinition<FeatureDefinitionMoveMode>("MoveModeFly10");

        internal static FeatureDefinitionMoveMode MoveModeFly12 { get; } =
            GetDefinition<FeatureDefinitionMoveMode>("MoveModeFly12");

        internal static FeatureDefinitionMoveMode MoveModeFly2 { get; } =
            GetDefinition<FeatureDefinitionMoveMode>("MoveModeFly2");

        internal static FeatureDefinitionMoveMode MoveModeMove8 { get; } =
            GetDefinition<FeatureDefinitionMoveMode>("MoveModeMove8");

        internal static FeatureDefinitionMoveMode MoveModeMove10 { get; } =
            GetDefinition<FeatureDefinitionMoveMode>("MoveModeMove10");

        internal static FeatureDefinitionMoveMode MoveModeMove2 { get; } =
            GetDefinition<FeatureDefinitionMoveMode>("MoveModeMove2");

        internal static FeatureDefinitionMoveMode MoveModeMove6 { get; } =
            GetDefinition<FeatureDefinitionMoveMode>("MoveModeMove6");

        internal static FeatureDefinitionMoveMode MoveModeMove7 { get; } =
            GetDefinition<FeatureDefinitionMoveMode>("MoveModeMove7");
    }

    internal static class FeatureDefinitionPointPools
    {
        internal static FeatureDefinitionPointPool PointPoolAbilityScoreImprovement { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolAbilityScoreImprovement");

        internal static FeatureDefinitionPointPool PointPoolBarbarianrSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolBarbarianrSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolBardSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolBardSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolBonusFeat { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolBonusFeat");

        internal static FeatureDefinitionPointPool PointPoolClericSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolClericSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolDruidSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolDruidSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolFighterSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolFighterSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolHalfElfSkillPool { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolHalfElfSkillPool");

        internal static FeatureDefinitionPointPool PointPoolHumanSkillPool { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolHumanSkillPool");

        internal static FeatureDefinitionPointPool PointPoolMonkSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolMonkSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolPaladinSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolPaladinSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolRangerSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolRangerSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolRogueSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolRogueSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolSorcererSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolSorcererSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolWarlockSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolWarlockSkillPoints");

        internal static FeatureDefinitionPointPool PointPoolWizardSkillPoints { get; } =
            GetDefinition<FeatureDefinitionPointPool>("PointPoolWizardSkillPoints");
    }

    internal static class FeatureDefinitionPowers
    {
        internal static FeatureDefinitionPower PowerCircleLandNaturalRecovery { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerCircleLandNaturalRecovery");

        internal static FeatureDefinitionPower PowerClericDivineInterventionWizard { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerClericDivineInterventionWizard");

        internal static FeatureDefinitionPower PowerDomainBattleDivineWrath { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDomainBattleDivineWrath");

        internal static FeatureDefinitionPower PowerDomainElementalFireBurst { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDomainElementalFireBurst");

        internal static FeatureDefinitionPower PowerDomainElementalHeraldOfTheElementsThunder { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDomainElementalHeraldOfTheElementsThunder");

        internal static FeatureDefinitionPower PowerDomainElementalLightningBlade { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDomainElementalLightningBlade");

        internal static FeatureDefinitionPower PowerDomainLawHolyRetribution { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDomainLawHolyRetribution");

        internal static FeatureDefinitionPower PowerDomainLawWordOfLaw { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDomainLawWordOfLaw");

        internal static FeatureDefinitionPower PowerDomainLifePreserveLife { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDomainLifePreserveLife");

        internal static FeatureDefinitionPower PowerDomainSunHeraldOfTheSun { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDomainSunHeraldOfTheSun");

        internal static FeatureDefinitionPower PowerDragonBreath_Acid { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDragonBreath_Acid");

        internal static FeatureDefinitionPower PowerDragonBreath_Poison { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDragonBreath_Poison");

        internal static FeatureDefinitionPower PowerDruidWildShape { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerDruidWildShape");

        internal static FeatureDefinitionPower PowerFighterActionSurge { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerFighterActionSurge");

        internal static FeatureDefinitionPower PowerFighterSecondWind { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerFighterSecondWind");

        internal static FeatureDefinitionPower PowerFunctionGoodberryHealing { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerFunctionGoodberryHealing");

        internal static FeatureDefinitionPower PowerFunctionGoodberryHealingOther { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerFunctionGoodberryHealingOther");

        internal static FeatureDefinitionPower PowerOathOfDevotionSacredWeapon { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerOathOfDevotionSacredWeapon");

        internal static FeatureDefinitionPower PowerOathOfJugementWeightOfJustice { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerOathOfJugementWeightOfJustice");

        internal static FeatureDefinitionPower PowerOathOfTirmarGoldenSpeech { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerOathOfTirmarGoldenSpeech");

        internal static FeatureDefinitionPower PowerPaladinAuraOfCourage { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerPaladinAuraOfCourage");

        internal static FeatureDefinitionPower PowerPaladinLayOnHands { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerPaladinLayOnHands");

        internal static FeatureDefinitionPower PowerRangerHideInPlainSight { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerRangerHideInPlainSight");

        internal static FeatureDefinitionPower PowerShadowcasterShadowDodge { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerShadowcasterShadowDodge");

        internal static FeatureDefinitionPower PowerShadowTamerRopeGrapple { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerShadowTamerRopeGrapple");

        internal static FeatureDefinitionPower PowerSorcererChildRiftDeflection { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerSorcererChildRiftDeflection");

        internal static FeatureDefinitionPower PowerSpiderQueenPoisonCloud { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerSpiderQueenPoisonCloud");

        internal static FeatureDefinitionPower PowerTraditionShockArcanistArcaneFury { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerTraditionShockArcanistArcaneFury");

        internal static FeatureDefinitionPower PowerVampiricTouch { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerVampiricTouch");

        internal static FeatureDefinitionPower PowerWizardArcaneRecovery { get; } =
            GetDefinition<FeatureDefinitionPower>("PowerWizardArcaneRecovery");
    }

    internal static class FeatureDefinitionProficiencys
    {
        internal static FeatureDefinitionProficiency ProficienctSpySkillsTool { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficienctSpySkillsTool");

        internal static FeatureDefinitionProficiency ProficiencyAcademicSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyAcademicSkills");

        internal static FeatureDefinitionProficiency ProficiencyAcademicSkillsTool { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyAcademicSkillsTool");

        internal static FeatureDefinitionProficiency ProficiencyAcolyteSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyAcolyteSkills");

        internal static FeatureDefinitionProficiency ProficiencyAcolyteToolsSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyAcolyteToolsSkills");

        internal static FeatureDefinitionProficiency ProficiencyAesceticSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyAesceticSkills");

        internal static FeatureDefinitionProficiency ProficiencyAesceticToolsSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyAesceticToolsSkills");

        internal static FeatureDefinitionProficiency ProficiencyAllLanguages { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyAllLanguages");

        internal static FeatureDefinitionProficiency ProficiencyAristocratSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyAristocratSkills");

        internal static FeatureDefinitionProficiency ProficiencyArtistSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyArtistSkills");

        internal static FeatureDefinitionProficiency ProficiencyBarbarianArmor { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyBarbarianArmor");

        internal static FeatureDefinitionProficiency ProficiencyBarbarianSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyBarbarianSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyBardSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyBardSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyBardWeapon { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyBardWeapon");

        internal static FeatureDefinitionProficiency ProficiencyClericArmor { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyClericArmor");

        internal static FeatureDefinitionProficiency ProficiencyClericSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyClericSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyClericWeapon { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyClericWeapon");

        internal static FeatureDefinitionProficiency ProficiencyDruidArmor { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyDruidArmor");

        internal static FeatureDefinitionProficiency ProficiencyDruidSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyDruidSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyDwarfLanguages { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyDwarfLanguages");

        internal static FeatureDefinitionProficiency ProficiencyFeatLockbreaker { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyFeatLockbreaker");

        internal static FeatureDefinitionProficiency ProficiencyFighterArmor { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyFighterArmor");

        internal static FeatureDefinitionProficiency ProficiencyFighterSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyFighterSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyFighterWeapon { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyFighterWeapon");

        internal static FeatureDefinitionProficiency ProficiencyLawkeeperSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyLawkeeperSkills");

        internal static FeatureDefinitionProficiency ProficiencyLowlifeSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyLowlifeSkills");

        internal static FeatureDefinitionProficiency ProficiencyLowLifeSkillsTools { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyLowLifeSkillsTools");

        internal static FeatureDefinitionProficiency ProficiencyMonkSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyMonkSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyOccultistSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyOccultistSkills");

        internal static FeatureDefinitionProficiency ProficiencyOccultistToolsSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyOccultistToolsSkills");

        internal static FeatureDefinitionProficiency ProficiencyPaladinArmor { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyPaladinArmor");

        internal static FeatureDefinitionProficiency ProficiencyPaladinSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyPaladinSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyPhilosopherSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyPhilosopherSkills");

        internal static FeatureDefinitionProficiency ProficiencyPhilosopherTools { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyPhilosopherTools");

        internal static FeatureDefinitionProficiency ProficiencyRangerSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyRangerSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyRogueSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyRogueSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyRogueWeapon { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyRogueWeapon");

        internal static FeatureDefinitionProficiency ProficiencySellSwordSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencySellSwordSkills");

        internal static FeatureDefinitionProficiency ProficiencySmithTools { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencySmithTools");

        internal static FeatureDefinitionProficiency ProficiencySorcererSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencySorcererSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencySorcererWeapon { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencySorcererWeapon");

        internal static FeatureDefinitionProficiency ProficiencySpySkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencySpySkills");

        internal static FeatureDefinitionProficiency ProficiencyWandererSkills { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyWandererSkills");

        internal static FeatureDefinitionProficiency ProficiencyWandererTools { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyWandererTools");

        internal static FeatureDefinitionProficiency ProficiencyWarlockSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyWarlockSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyWarlockWeapon { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyWarlockWeapon");

        internal static FeatureDefinitionProficiency ProficiencyWizardSavingThrow { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyWizardSavingThrow");

        internal static FeatureDefinitionProficiency ProficiencyWizardWeapon { get; } =
            GetDefinition<FeatureDefinitionProficiency>("ProficiencyWizardWeapon");
    }

    internal static class FeatureDefinitionRegenerations
    {
        internal static FeatureDefinitionRegeneration RegenerationRing { get; } =
            GetDefinition<FeatureDefinitionRegeneration>("RegenerationRing");
    }

    internal static class FeatureDefinitionSavingThrowAffinitys
    {
        internal static FeatureDefinitionSavingThrowAffinity SavingThrowAffinityConditionBlessed { get; } =
            GetDefinition<FeatureDefinitionSavingThrowAffinity>("SavingThrowAffinityConditionBlessed");

        internal static FeatureDefinitionSavingThrowAffinity SavingThrowAffinityConditionRaging { get; } =
            GetDefinition<FeatureDefinitionSavingThrowAffinity>("SavingThrowAffinityConditionRaging");

        internal static FeatureDefinitionSavingThrowAffinity SavingThrowAffinityCreedOfArun { get; } =
            GetDefinition<FeatureDefinitionSavingThrowAffinity>("SavingThrowAffinityCreedOfArun");

        internal static FeatureDefinitionSavingThrowAffinity SavingThrowAffinityCreedOfSolasta { get; } =
            GetDefinition<FeatureDefinitionSavingThrowAffinity>("SavingThrowAffinityCreedOfSolasta");

        internal static FeatureDefinitionSavingThrowAffinity SavingThrowAffinityGemIllusion { get; } =
            GetDefinition<FeatureDefinitionSavingThrowAffinity>("SavingThrowAffinityGemIllusion");

        internal static FeatureDefinitionSavingThrowAffinity SavingThrowAffinityShelteringBreeze { get; } =
            GetDefinition<FeatureDefinitionSavingThrowAffinity>("SavingThrowAffinityShelteringBreeze");
    }

    internal static class FeatureDefinitionSenses
    {
        internal static FeatureDefinitionSense SenseDarkvision12 { get; } =
            GetDefinition<FeatureDefinitionSense>("SenseDarkvision12");

        internal static FeatureDefinitionSense SenseDarkvision24 { get; } =
            GetDefinition<FeatureDefinitionSense>("SenseDarkvision24");

        internal static FeatureDefinitionSense SenseNormalVision { get; } =
            GetDefinition<FeatureDefinitionSense>("SenseNormalVision");

        internal static FeatureDefinitionSense SenseSeeInvisible16 { get; } =
            GetDefinition<FeatureDefinitionSense>("SenseSeeInvisible16");

        internal static FeatureDefinitionSense SenseSuperiorDarkvision { get; } =
            GetDefinition<FeatureDefinitionSense>("SenseSuperiorDarkvision");
    }

    internal static class FeatureDefinitionSubclassChoices
    {
        internal static FeatureDefinitionSubclassChoice SubclassChoiceBarbarianPrimalPath { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceBarbarianPrimalPath");

        internal static FeatureDefinitionSubclassChoice SubclassChoiceDruidCircle { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceDruidCircle");

        internal static FeatureDefinitionSubclassChoice SubclassChoiceFighterMartialArchetypes { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceFighterMartialArchetypes");

        internal static FeatureDefinitionSubclassChoice SubclassChoiceMonkMonasticTraditions { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceMonkMonasticTraditions");

        internal static FeatureDefinitionSubclassChoice SubclassChoiceRangerArchetypes { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceRangerArchetypes");

        internal static FeatureDefinitionSubclassChoice SubclassChoiceRogueRoguishArchetypes { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceRogueRoguishArchetypes");

        internal static FeatureDefinitionSubclassChoice SubclassChoiceSorcerousOrigin { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceSorcerousOrigin");

        internal static FeatureDefinitionSubclassChoice SubclassChoiceWarlockOtherworldlyPatrons { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceWarlockOtherworldlyPatrons");

        internal static FeatureDefinitionSubclassChoice SubclassChoiceWizardArcaneTraditions { get; } =
            GetDefinition<FeatureDefinitionSubclassChoice>("SubclassChoiceWizardArcaneTraditions");
    }

    internal static class FeatureDefinitionSummoningAffinitys
    {
        internal static FeatureDefinitionSummoningAffinity SummoningAffinityKindredSpiritBond { get; } =
            GetDefinition<FeatureDefinitionSummoningAffinity>("SummoningAffinityKindredSpiritBond");
    }

    internal static class ItemDefinitions
    {
        internal static ItemDefinition _100_GP_Emerald { get; } =
            GetDefinition<ItemDefinition>("100_GP_Emerald");

        internal static ItemDefinition _100_GP_Pearl { get; } =
            GetDefinition<ItemDefinition>("100_GP_Pearl");

        internal static ItemDefinition _1000_GP_Diamond { get; } =
            GetDefinition<ItemDefinition>("1000_GP_Diamond");

        internal static ItemDefinition _20_GP_Amethyst { get; } =
            GetDefinition<ItemDefinition>("20_GP_Amethyst");

        internal static ItemDefinition _300_GP_Opal { get; } =
            GetDefinition<ItemDefinition>("300_GP_Opal");

        internal static ItemDefinition _50_GP_Sapphire { get; } =
            GetDefinition<ItemDefinition>("50_GP_Sapphire");

        internal static ItemDefinition _500_GP_Ruby { get; } =
            GetDefinition<ItemDefinition>("500_GP_Ruby");

        internal static ItemDefinition ABJURATION_MastersmithLoreDocument { get; } =
            GetDefinition<ItemDefinition>("ABJURATION_MastersmithLoreDocument");

        internal static ItemDefinition ABJURATION_TOWER_ElvenWars { get; } =
            GetDefinition<ItemDefinition>("ABJURATION_TOWER_ElvenWars");

        internal static ItemDefinition ABJURATION_TOWER_Manifest { get; } =
            GetDefinition<ItemDefinition>("ABJURATION_TOWER_Manifest");

        internal static ItemDefinition ABJURATION_TOWER_Poem { get; } =
            GetDefinition<ItemDefinition>("ABJURATION_TOWER_Poem");

        internal static ItemDefinition AlchemistFire { get; } =
            GetDefinition<ItemDefinition>("AlchemistFire");

        internal static ItemDefinition AmuletOfHealth { get; } =
            GetDefinition<ItemDefinition>("AmuletOfHealth");

        internal static ItemDefinition ArcaneShieldstaff { get; } =
            GetDefinition<ItemDefinition>("ArcaneShieldstaff");

        internal static ItemDefinition Art_Item_25_GP_EngraveBoneDice { get; } =
            GetDefinition<ItemDefinition>("Art_Item_25_GP_EngraveBoneDice");

        internal static ItemDefinition Art_Item_25_GP_SilverChalice { get; } =
            GetDefinition<ItemDefinition>("Art_Item_25_GP_SilverChalice");

        internal static ItemDefinition Art_Item_50_GP_JadePendant { get; } =
            GetDefinition<ItemDefinition>("Art_Item_50_GP_JadePendant");

        internal static ItemDefinition Backpack_Bag_Of_Holding { get; } =
            GetDefinition<ItemDefinition>("Backpack_Bag_Of_Holding");

        internal static ItemDefinition BarbarianClothes { get; } =
            GetDefinition<ItemDefinition>("BarbarianClothes");

        internal static ItemDefinition Battleaxe { get; } =
            GetDefinition<ItemDefinition>("Battleaxe");

        internal static ItemDefinition BattleaxePlus1 { get; } =
            GetDefinition<ItemDefinition>("Battleaxe+1");

        internal static ItemDefinition BeltOfGiantHillStrength { get; } =
            GetDefinition<ItemDefinition>("BeltOfGiantHillStrength");

        internal static ItemDefinition BeltOfRegeneration { get; } =
            GetDefinition<ItemDefinition>("BeltOfRegeneration");

        internal static ItemDefinition Berry_Ration { get; } =
            GetDefinition<ItemDefinition>("Berry_Ration");

        internal static ItemDefinition Bolt { get; } =
            GetDefinition<ItemDefinition>("Bolt");

        internal static ItemDefinition BONEKEEP_AkshasJournal { get; } =
            GetDefinition<ItemDefinition>("BONEKEEP_AkshasJournal");

        internal static ItemDefinition BONEKEEP_MagicRune { get; } =
            GetDefinition<ItemDefinition>("BONEKEEP_MagicRune");

        internal static ItemDefinition BootsLevitation { get; } =
            GetDefinition<ItemDefinition>("BootsLevitation");

        internal static ItemDefinition BootsOfElvenKind { get; } =
            GetDefinition<ItemDefinition>("BootsOfElvenKind");

        internal static ItemDefinition BootsOfStridingAndSpringing { get; } =
            GetDefinition<ItemDefinition>("BootsOfStridingAndSpringing");

        internal static ItemDefinition BootsWinged { get; } =
            GetDefinition<ItemDefinition>("BootsWinged");

        internal static ItemDefinition Bracers_Of_Archery { get; } =
            GetDefinition<ItemDefinition>("Bracers_Of_Archery");

        internal static ItemDefinition Bracers_Of_Defense { get; } =
            GetDefinition<ItemDefinition>("Bracers_Of_Defense");

        internal static ItemDefinition Breastplate { get; } =
            GetDefinition<ItemDefinition>("Breastplate");

        internal static ItemDefinition BroochOfShielding { get; } =
            GetDefinition<ItemDefinition>("BroochOfShielding");

        internal static ItemDefinition CAERLEM_Daliat_Document { get; } =
            GetDefinition<ItemDefinition>("CAERLEM_Daliat_Document");

        internal static ItemDefinition CaerLem_Gate_Plaque { get; } =
            GetDefinition<ItemDefinition>("CaerLem_Gate_Plaque");

        internal static ItemDefinition CAERLEM_Inquisitor_Document { get; } =
            GetDefinition<ItemDefinition>("CAERLEM_Inquisitor_Document");

        internal static ItemDefinition CAERLEM_TirmarianHolySymbol { get; } =
            GetDefinition<ItemDefinition>("CAERLEM_TirmarianHolySymbol");

        internal static ItemDefinition ChainMail { get; } =
            GetDefinition<ItemDefinition>("ChainMail");

        internal static ItemDefinition ChainShirt { get; } =
            GetDefinition<ItemDefinition>("ChainShirt");

        internal static ItemDefinition CloakOfElvenkind { get; } =
            GetDefinition<ItemDefinition>("CloakOfElvenkind");

        internal static ItemDefinition CloakOfProtection { get; } =
            GetDefinition<ItemDefinition>("CloakOfProtection");

        internal static ItemDefinition ClothesCommon_Tattoo { get; } =
            GetDefinition<ItemDefinition>("ClothesCommon_Tattoo");

        internal static ItemDefinition ClothesNoble_Valley { get; } =
            GetDefinition<ItemDefinition>("ClothesNoble_Valley");

        internal static ItemDefinition ClothesNoble_Valley_Cherry { get; } =
            GetDefinition<ItemDefinition>("ClothesNoble_Valley_Cherry");

        internal static ItemDefinition ClothesNoble_Valley_Green { get; } =
            GetDefinition<ItemDefinition>("ClothesNoble_Valley_Green");

        internal static ItemDefinition ClothesNoble_Valley_Orange { get; } =
            GetDefinition<ItemDefinition>("ClothesNoble_Valley_Orange");

        internal static ItemDefinition ClothesNoble_Valley_Pink { get; } =
            GetDefinition<ItemDefinition>("ClothesNoble_Valley_Pink");

        internal static ItemDefinition ClothesNoble_Valley_Purple { get; } =
            GetDefinition<ItemDefinition>("ClothesNoble_Valley_Purple");

        internal static ItemDefinition ClothesNoble_Valley_Red { get; } =
            GetDefinition<ItemDefinition>("ClothesNoble_Valley_Red");

        internal static ItemDefinition ClothesNoble_Valley_Silver { get; } =
            GetDefinition<ItemDefinition>("ClothesNoble_Valley_Silver");

        internal static ItemDefinition ClothesWizard { get; } =
            GetDefinition<ItemDefinition>("ClothesWizard");

        internal static ItemDefinition ClothesWizard_B { get; } =
            GetDefinition<ItemDefinition>("ClothesWizard_B");

        internal static ItemDefinition Club { get; } =
            GetDefinition<ItemDefinition>("Club");

        internal static ItemDefinition ComponentPouch_Belt { get; } =
            GetDefinition<ItemDefinition>("ComponentPouch_Belt");

        internal static ItemDefinition ComponentPouch_Bracers { get; } =
            GetDefinition<ItemDefinition>("ComponentPouch_Bracers");

        internal static ItemDefinition ComponentPouch { get; } =
            GetDefinition<ItemDefinition>("ComponentPouch");

        internal static ItemDefinition ComponentPouch_ArcaneAmulet { get; } =
            GetDefinition<ItemDefinition>("ComponentPouch_ArcaneAmulet");

        internal static ItemDefinition CraftingManual_Enchant_EmpressGarb { get; } =
            GetDefinition<ItemDefinition>("CraftingManual_Enchant_EmpressGarb");

        internal static ItemDefinition CraftingManual_Enchant_Longbow_Of_Accuracy { get; } =
            GetDefinition<ItemDefinition>("CraftingManual_Enchant_Longbow_Of_Accuracy");

        internal static ItemDefinition CraftingManual_Enchant_Longsword_Warden { get; } =
            GetDefinition<ItemDefinition>("CraftingManual_Enchant_Longsword_Warden");

        internal static ItemDefinition CraftingManualRemedy { get; } =
            GetDefinition<ItemDefinition>("CraftingManualRemedy");

        internal static ItemDefinition CraftingManualScrollOfVampiricTouch { get; } =
            GetDefinition<ItemDefinition>("CraftingManualScrollOfVampiricTouch");

        internal static ItemDefinition CrownOfTheMagister { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister");

        internal static ItemDefinition CrownOfTheMagister01 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister01");

        internal static ItemDefinition CrownOfTheMagister02 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister02");

        internal static ItemDefinition CrownOfTheMagister03 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister03");

        internal static ItemDefinition CrownOfTheMagister04 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister04");

        internal static ItemDefinition CrownOfTheMagister05 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister05");

        internal static ItemDefinition CrownOfTheMagister06 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister06");

        internal static ItemDefinition CrownOfTheMagister07 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister07");

        internal static ItemDefinition CrownOfTheMagister08 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister08");

        internal static ItemDefinition CrownOfTheMagister09 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister09");

        internal static ItemDefinition CrownOfTheMagister10 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister10");

        internal static ItemDefinition CrownOfTheMagister11 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister11");

        internal static ItemDefinition CrownOfTheMagister12 { get; } =
            GetDefinition<ItemDefinition>("CrownOfTheMagister12");

        internal static ItemDefinition Dagger { get; } =
            GetDefinition<ItemDefinition>("Dagger");

        internal static ItemDefinition Dart { get; } =
            GetDefinition<ItemDefinition>("Dart");

        internal static ItemDefinition DruidicFocus { get; } =
            GetDefinition<ItemDefinition>("DruidicFocus");

        internal static ItemDefinition DungeoneerPack { get; } =
            GetDefinition<ItemDefinition>("DungeoneerPack");

        internal static ItemDefinition ElvenChain { get; } =
            GetDefinition<ItemDefinition>("ElvenChain");

        internal static ItemDefinition Enchanted_Battleaxe_Punisher { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Battleaxe_Punisher");

        internal static ItemDefinition Enchanted_BreastplateOfDeflection { get; } =
            GetDefinition<ItemDefinition>("Enchanted_BreastplateOfDeflection");

        internal static ItemDefinition Enchanted_ChainShirt_Empress_war_garb { get; } =
            GetDefinition<ItemDefinition>("Enchanted_ChainShirt_Empress_war_garb");

        internal static ItemDefinition Enchanted_Dagger_Frostburn { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Dagger_Frostburn");

        internal static ItemDefinition Enchanted_Dagger_of_Acuteness { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Dagger_of_Acuteness");

        internal static ItemDefinition Enchanted_Dagger_of_Sharpness { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Dagger_of_Sharpness");

        internal static ItemDefinition Enchanted_Dagger_Souldrinker { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Dagger_Souldrinker");

        internal static ItemDefinition Enchanted_Greatsword_Lightbringer { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Greatsword_Lightbringer");

        internal static ItemDefinition Enchanted_HalfPlateOfRobustness { get; } =
            GetDefinition<ItemDefinition>("Enchanted_HalfPlateOfRobustness");

        internal static ItemDefinition Enchanted_HalfPlateOfSturdiness { get; } =
            GetDefinition<ItemDefinition>("Enchanted_HalfPlateOfSturdiness");

        internal static ItemDefinition Enchanted_LeatherArmorOfFlameDancing { get; } =
            GetDefinition<ItemDefinition>("Enchanted_LeatherArmorOfFlameDancing");

        internal static ItemDefinition Enchanted_LeatherArmorOfSurvival { get; } =
            GetDefinition<ItemDefinition>("Enchanted_LeatherArmorOfSurvival");

        internal static ItemDefinition Enchanted_Longbow_Lightbringer { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Longbow_Lightbringer");

        internal static ItemDefinition Enchanted_Longbow_Of_Accurary { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Longbow_Of_Accurary");

        internal static ItemDefinition Enchanted_Longbow_Stormbow { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Longbow_Stormbow");

        internal static ItemDefinition Enchanted_Longsword_Dragonblade { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Longsword_Dragonblade");

        internal static ItemDefinition Enchanted_Longsword_Frostburn { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Longsword_Frostburn");

        internal static ItemDefinition Enchanted_Longsword_Stormblade { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Longsword_Stormblade");

        internal static ItemDefinition Enchanted_Longsword_Warden { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Longsword_Warden");

        internal static ItemDefinition Enchanted_Mace_Of_Acuteness { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Mace_Of_Acuteness");

        internal static ItemDefinition Enchanted_Morningstar_Bearclaw { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Morningstar_Bearclaw");

        internal static ItemDefinition Enchanted_Morningstar_Of_Power { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Morningstar_Of_Power");

        internal static ItemDefinition Enchanted_Rapier_Blackadder { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Rapier_Blackadder");

        internal static ItemDefinition Enchanted_Rapier_Doomblade { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Rapier_Doomblade");

        internal static ItemDefinition Enchanted_Rapier_Of_Acuteness { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Rapier_Of_Acuteness");

        internal static ItemDefinition Enchanted_ScaleMailOfIceDancing { get; } =
            GetDefinition<ItemDefinition>("Enchanted_ScaleMailOfIceDancing");

        internal static ItemDefinition Enchanted_Shortbow_Medusa { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Shortbow_Medusa");

        internal static ItemDefinition Enchanted_Shortbow_Of_Sharpshooting { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Shortbow_Of_Sharpshooting");

        internal static ItemDefinition Enchanted_Shortsword_Lightbringer { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Shortsword_Lightbringer");

        internal static ItemDefinition Enchanted_Shortsword_of_Sharpness { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Shortsword_of_Sharpness");

        internal static ItemDefinition Enchanted_Shortsword_Whiteburn { get; } =
            GetDefinition<ItemDefinition>("Enchanted_Shortsword_Whiteburn");

        internal static ItemDefinition ExplorerPack { get; } =
            GetDefinition<ItemDefinition>("ExplorerPack");

        internal static ItemDefinition Flute { get; } =
            GetDefinition<ItemDefinition>("Flute");

        internal static ItemDefinition Food_Ration { get; } =
            GetDefinition<ItemDefinition>("Food_Ration");

        internal static ItemDefinition Food_Ration_Foraged { get; } =
            GetDefinition<ItemDefinition>("Food_Ration_Foraged");

        internal static ItemDefinition GauntletsOfOgrePower { get; } =
            GetDefinition<ItemDefinition>("GauntletsOfOgrePower");

        internal static ItemDefinition GemOfSeeing { get; } =
            GetDefinition<ItemDefinition>("GemOfSeeing");

        internal static ItemDefinition GlovesOfMissileSnaring { get; } =
            GetDefinition<ItemDefinition>("GlovesOfMissileSnaring");

        internal static ItemDefinition Greataxe { get; } =
            GetDefinition<ItemDefinition>("Greataxe");

        internal static ItemDefinition GreataxePlus1 { get; } =
            GetDefinition<ItemDefinition>("Greataxe+1");

        internal static ItemDefinition Greatsword { get; } =
            GetDefinition<ItemDefinition>("Greatsword");

        internal static ItemDefinition GreenmageArmor { get; } =
            GetDefinition<ItemDefinition>("GreenmageArmor");

        internal static ItemDefinition HalfPlate { get; } =
            GetDefinition<ItemDefinition>("HalfPlate");

        internal static ItemDefinition Handaxe { get; } =
            GetDefinition<ItemDefinition>("Handaxe");

        internal static ItemDefinition HeadbandOfIntellect { get; } =
            GetDefinition<ItemDefinition>("HeadbandOfIntellect");

        internal static ItemDefinition HeavyCrossbow { get; } =
            GetDefinition<ItemDefinition>("HeavyCrossbow");

        internal static ItemDefinition HideArmor { get; } =
            GetDefinition<ItemDefinition>("HideArmor");

        internal static ItemDefinition HolySymbolAmulet { get; } =
            GetDefinition<ItemDefinition>("HolySymbolAmulet");

        internal static ItemDefinition HornOfBlasting { get; } =
            GetDefinition<ItemDefinition>("HornOfBlasting");

        internal static ItemDefinition Ingredient_AbyssMoss { get; } =
            GetDefinition<ItemDefinition>("Ingredient_AbyssMoss");

        internal static ItemDefinition Ingredient_Acid { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Acid");

        internal static ItemDefinition Ingredient_AngryViolet { get; } =
            GetDefinition<ItemDefinition>("Ingredient_AngryViolet");

        internal static ItemDefinition Ingredient_BadlandsSpiderVenomGland { get; } =
            GetDefinition<ItemDefinition>("Ingredient_BadlandsSpiderVenomGland");

        internal static ItemDefinition Ingredient_BloodDaffodil { get; } =
            GetDefinition<ItemDefinition>("Ingredient_BloodDaffodil");

        internal static ItemDefinition Ingredient_Enchant_Blood_Gem { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Blood_Gem");

        internal static ItemDefinition Ingredient_Enchant_Blood_Of_Solasta { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Blood_Of_Solasta");

        internal static ItemDefinition Ingredient_Enchant_Cloud_Diamond { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Cloud_Diamond");

        internal static ItemDefinition Ingredient_Enchant_Crystal_Of_Winter { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Crystal_Of_Winter");

        internal static ItemDefinition Ingredient_Enchant_Diamond_Of_Elai { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Diamond_Of_Elai");

        internal static ItemDefinition Ingredient_Enchant_Doom_Gem { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Doom_Gem");

        internal static ItemDefinition Ingredient_Enchant_Heartstone { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Heartstone");

        internal static ItemDefinition Ingredient_Enchant_LifeStone { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_LifeStone");

        internal static ItemDefinition Ingredient_Enchant_Medusa_Coral { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Medusa_Coral");

        internal static ItemDefinition Ingredient_Enchant_MithralStone { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_MithralStone");

        internal static ItemDefinition Ingredient_Enchant_Oil_Of_Acuteness { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Oil_Of_Acuteness");

        internal static ItemDefinition Ingredient_Enchant_PurpleAmber { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_PurpleAmber");

        internal static ItemDefinition Ingredient_Enchant_Shard_Of_Fire { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Shard_Of_Fire");

        internal static ItemDefinition Ingredient_Enchant_Shard_Of_Ice { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Shard_Of_Ice");

        internal static ItemDefinition Ingredient_Enchant_Slavestone { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Slavestone");

        internal static ItemDefinition Ingredient_Enchant_Soul_Gem { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Soul_Gem");

        internal static ItemDefinition Ingredient_Enchant_SpiderQueen_Venom { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_SpiderQueen_Venom");

        internal static ItemDefinition Ingredient_Enchant_Stardust { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Enchant_Stardust");

        internal static ItemDefinition Ingredient_LilyOfTheBadlands { get; } =
            GetDefinition<ItemDefinition>("Ingredient_LilyOfTheBadlands");

        internal static ItemDefinition Ingredient_ManacalonOrchid { get; } =
            GetDefinition<ItemDefinition>("Ingredient_ManacalonOrchid");

        internal static ItemDefinition Ingredient_PrimordialLavaStones { get; } =
            GetDefinition<ItemDefinition>("Ingredient_PrimordialLavaStones");

        internal static ItemDefinition Ingredient_RefinedOil { get; } =
            GetDefinition<ItemDefinition>("Ingredient_RefinedOil");

        internal static ItemDefinition Ingredient_Skarn { get; } =
            GetDefinition<ItemDefinition>("Ingredient_Skarn");

        internal static ItemDefinition Javelin { get; } =
            GetDefinition<ItemDefinition>("Javelin");

        internal static ItemDefinition Leather { get; } =
            GetDefinition<ItemDefinition>("Leather");

        internal static ItemDefinition LeatherDruid { get; } =
            GetDefinition<ItemDefinition>("LeatherDruid");

        internal static ItemDefinition LightCrossbow { get; } =
            GetDefinition<ItemDefinition>("LightCrossbow");

        internal static ItemDefinition LightCrossbowPlus2 { get; } =
            GetDefinition<ItemDefinition>("LightCrossbow+2");

        internal static ItemDefinition Longbow { get; } =
            GetDefinition<ItemDefinition>("Longbow");

        internal static ItemDefinition Longsword { get; } =
            GetDefinition<ItemDefinition>("Longsword");

        internal static ItemDefinition Mace { get; } =
            GetDefinition<ItemDefinition>("Mace");

        internal static ItemDefinition MacePlus2 { get; } =
            GetDefinition<ItemDefinition>("Mace+2");

        internal static ItemDefinition Maul { get; } =
            GetDefinition<ItemDefinition>("Maul");

        internal static ItemDefinition Morningstar { get; } =
            GetDefinition<ItemDefinition>("Morningstar");

        internal static ItemDefinition MorningstarPlus2 { get; } =
            GetDefinition<ItemDefinition>("Morningstar+2");

        internal static ItemDefinition PaddedLeather { get; } =
            GetDefinition<ItemDefinition>("PaddedLeather");

        internal static ItemDefinition PipesOfHaunting { get; } =
            GetDefinition<ItemDefinition>("PipesOfHaunting");

        internal static ItemDefinition Plate { get; } =
            GetDefinition<ItemDefinition>("Plate");

        internal static ItemDefinition Poison_Basic { get; } =
            GetDefinition<ItemDefinition>("Poison_Basic");

        internal static ItemDefinition PotionOfClimbing { get; } =
            GetDefinition<ItemDefinition>("PotionOfClimbing");

        internal static ItemDefinition PotionOfHealing { get; } =
            GetDefinition<ItemDefinition>("PotionOfHealing");

        internal static ItemDefinition PotionOfHeroism { get; } =
            GetDefinition<ItemDefinition>("PotionOfHeroism");

        internal static ItemDefinition PotionOfInvisibility { get; } =
            GetDefinition<ItemDefinition>("PotionOfInvisibility");

        internal static ItemDefinition PotionOfSpeed { get; } =
            GetDefinition<ItemDefinition>("PotionOfSpeed");

        internal static ItemDefinition PotionRemedy { get; } =
            GetDefinition<ItemDefinition>("PotionRemedy");

        internal static ItemDefinition Primed_Battleaxe { get; } =
            GetDefinition<ItemDefinition>("Primed Battleaxe");

        internal static ItemDefinition Primed_Breastplate { get; } =
            GetDefinition<ItemDefinition>("Primed Breastplate");

        internal static ItemDefinition Primed_ChainMail { get; } =
            GetDefinition<ItemDefinition>("Primed ChainMail");

        internal static ItemDefinition Primed_ChainShirt { get; } =
            GetDefinition<ItemDefinition>("Primed ChainShirt");

        internal static ItemDefinition Primed_Dagger { get; } =
            GetDefinition<ItemDefinition>("Primed Dagger");

        internal static ItemDefinition Primed_Greataxe { get; } =
            GetDefinition<ItemDefinition>("Primed Greataxe");

        internal static ItemDefinition Primed_Greatsword { get; } =
            GetDefinition<ItemDefinition>("Primed Greatsword");

        internal static ItemDefinition Primed_HalfPlate { get; } =
            GetDefinition<ItemDefinition>("Primed HalfPlate");

        internal static ItemDefinition Primed_Leather_Armor { get; } =
            GetDefinition<ItemDefinition>("Primed Leather Armor");

        internal static ItemDefinition Primed_Longbow { get; } =
            GetDefinition<ItemDefinition>("Primed Longbow");

        internal static ItemDefinition Primed_Mace { get; } =
            GetDefinition<ItemDefinition>("Primed Mace");

        internal static ItemDefinition Primed_Morningstar { get; } =
            GetDefinition<ItemDefinition>("Primed Morningstar");

        internal static ItemDefinition Primed_Plate { get; } =
            GetDefinition<ItemDefinition>("Primed Plate");

        internal static ItemDefinition Primed_Rapier { get; } =
            GetDefinition<ItemDefinition>("Primed Rapier");

        internal static ItemDefinition Primed_ScaleMail { get; } =
            GetDefinition<ItemDefinition>("Primed ScaleMail");

        internal static ItemDefinition Primed_Scimitar { get; } =
            GetDefinition<ItemDefinition>("Primed Scimitar");

        internal static ItemDefinition Primed_Shortbow { get; } =
            GetDefinition<ItemDefinition>("Primed Shortbow");

        internal static ItemDefinition Primed_Shortsword { get; } =
            GetDefinition<ItemDefinition>("Primed Shortsword");

        internal static ItemDefinition Primed_HeavyCrossbow { get; } =
            GetDefinition<ItemDefinition>("Primed_HeavyCrossbow");

        internal static ItemDefinition Primed_HideArmor { get; } =
            GetDefinition<ItemDefinition>("Primed_HideArmor");

        internal static ItemDefinition Primed_LeatherDruid { get; } =
            GetDefinition<ItemDefinition>("Primed_LeatherDruid");

        internal static ItemDefinition Primed_LightCrossbow { get; } =
            GetDefinition<ItemDefinition>("Primed_LightCrossbow");

        internal static ItemDefinition Primed_Longsword { get; } =
            GetDefinition<ItemDefinition>("Primed_Longsword");

        internal static ItemDefinition Primed_Maul { get; } =
            GetDefinition<ItemDefinition>("Primed_Maul");

        internal static ItemDefinition Primed_Spear { get; } =
            GetDefinition<ItemDefinition>("Primed_Spear");

        internal static ItemDefinition Primed_StuddedLeather { get; } =
            GetDefinition<ItemDefinition>("Primed_StuddedLeather");

        internal static ItemDefinition Primed_Warhammer { get; } =
            GetDefinition<ItemDefinition>("Primed_Warhammer");

        internal static ItemDefinition ProducedFlame { get; } =
            GetDefinition<ItemDefinition>("ProducedFlame");

        internal static ItemDefinition Quarterstaff { get; } =
            GetDefinition<ItemDefinition>("Quarterstaff");

        internal static ItemDefinition QuarterstaffPlus1 { get; } =
            GetDefinition<ItemDefinition>("Quarterstaff+1");

        internal static ItemDefinition Rapier { get; } =
            GetDefinition<ItemDefinition>("Rapier");

        internal static ItemDefinition Ringmail { get; } =
            GetDefinition<ItemDefinition>("Ringmail");

        internal static ItemDefinition RingProtectionPlus1 { get; } =
            GetDefinition<ItemDefinition>("RingProtection+1");

        internal static ItemDefinition ScaleMail { get; } =
            GetDefinition<ItemDefinition>("ScaleMail");

        internal static ItemDefinition Scimitar { get; } =
            GetDefinition<ItemDefinition>("Scimitar");

        internal static ItemDefinition ScrollFly { get; } =
            GetDefinition<ItemDefinition>("ScrollFly");

        internal static ItemDefinition Shield { get; } =
            GetDefinition<ItemDefinition>("Shield");

        internal static ItemDefinition Shield_Wooden { get; } =
            GetDefinition<ItemDefinition>("Shield_Wooden");

        internal static ItemDefinition Shortbow { get; } =
            GetDefinition<ItemDefinition>("Shortbow");

        internal static ItemDefinition Shortsword { get; } =
            GetDefinition<ItemDefinition>("Shortsword");

        internal static ItemDefinition SlippersOfSpiderClimbing { get; } =
            GetDefinition<ItemDefinition>("SlippersOfSpiderClimbing");

        internal static ItemDefinition SorcererArmor { get; } =
            GetDefinition<ItemDefinition>("SorcererArmor");

        internal static ItemDefinition Spear { get; } =
            GetDefinition<ItemDefinition>("Spear");

        internal static ItemDefinition Spellbook { get; } =
            GetDefinition<ItemDefinition>("Spellbook");

        internal static ItemDefinition SplintArmor { get; } =
            GetDefinition<ItemDefinition>("SplintArmor");

        internal static ItemDefinition StaffOfHealing { get; } =
            GetDefinition<ItemDefinition>("StaffOfHealing");

        internal static ItemDefinition StuddedLeather { get; } =
            GetDefinition<ItemDefinition>("StuddedLeather");

        internal static ItemDefinition UnarmedStrikeBase { get; } =
            GetDefinition<ItemDefinition>("UnarmedStrikeBase");

        internal static ItemDefinition WandOfIdentify { get; } =
            GetDefinition<ItemDefinition>("WandOfIdentify");

        internal static ItemDefinition WandOfMagicDetection { get; } =
            GetDefinition<ItemDefinition>("WandOfMagicDetection");

        internal static ItemDefinition WandMagicMissile { get; } =
            GetDefinition<ItemDefinition>("WandMagicMissile");

        internal static ItemDefinition Warhammer { get; } =
            GetDefinition<ItemDefinition>("Warhammer");

        internal static ItemDefinition WizardClothes_Alternate { get; } =
            GetDefinition<ItemDefinition>("WizardClothes_Alternate");
    }

    internal static class ItemFlagDefinitions
    {
        internal static ItemFlagDefinition ItemFlagPrimed { get; } =
            GetDefinition<ItemFlagDefinition>("ItemFlagPrimed");
    }

    internal static class KnowledgeLevelDefinitions
    {
        internal static KnowledgeLevelDefinition Mastered4 { get; } =
            GetDefinition<KnowledgeLevelDefinition>("Mastered4");
    }

    internal static class MerchantCategoryDefinitions
    {
        internal static MerchantCategoryDefinition All { get; } =
            GetDefinition<MerchantCategoryDefinition>("All");

        internal static MerchantCategoryDefinition Crafting { get; } =
            GetDefinition<MerchantCategoryDefinition>("Crafting");

        internal static MerchantCategoryDefinition Weapon { get; } =
            GetDefinition<MerchantCategoryDefinition>("Weapon");
    }

    internal static class MerchantDefinitions
    {
        internal static MerchantDefinition Store_Merchant_Antiquarians_Halman_Summer { get; } =
            GetDefinition<MerchantDefinition>("Store_Merchant_Antiquarians_Halman_Summer");

        internal static MerchantDefinition Store_Merchant_Arcaneum_Heddlon_Surespell { get; } =
            GetDefinition<MerchantDefinition>("Store_Merchant_Arcaneum_Heddlon_Surespell");

        internal static MerchantDefinition Store_Merchant_CircleOfDanantar_Joriel_Foxeye { get; } =
            GetDefinition<MerchantDefinition>("Store_Merchant_CircleOfDanantar_Joriel_Foxeye");

        internal static MerchantDefinition Store_Merchant_Gorim_Ironsoot_Cyflen_GeneralStore { get; } =
            GetDefinition<MerchantDefinition>("Store_Merchant_Gorim_Ironsoot_Cyflen_GeneralStore");

        internal static MerchantDefinition Store_Merchant_Hugo_Requer_Cyflen_Potions { get; } =
            GetDefinition<MerchantDefinition>("Store_Merchant_Hugo_Requer_Cyflen_Potions");

        internal static MerchantDefinition Store_Merchant_TowerOfKnowledge_Maddy_Greenisle { get; } =
            GetDefinition<MerchantDefinition>("Store_Merchant_TowerOfKnowledge_Maddy_Greenisle");
    }

    internal static class MetamagicOptionDefinitions
    {
        internal static MetamagicOptionDefinition MetamagicCarefullSpell { get; } =
            GetDefinition<MetamagicOptionDefinition>("MetamagicCarefullSpell");

        internal static MetamagicOptionDefinition MetamagicDistantSpell { get; } =
            GetDefinition<MetamagicOptionDefinition>("MetamagicDistantSpell");

        internal static MetamagicOptionDefinition MetamagicEmpoweredSpell { get; } =
            GetDefinition<MetamagicOptionDefinition>("MetamagicEmpoweredSpell");

        internal static MetamagicOptionDefinition MetamagicExtendedSpell { get; } =
            GetDefinition<MetamagicOptionDefinition>("MetamagicExtendedSpell");

        internal static MetamagicOptionDefinition MetamagicHeightenedSpell { get; } =
            GetDefinition<MetamagicOptionDefinition>("MetamagicHeightenedSpell");

        internal static MetamagicOptionDefinition MetamagicQuickenedSpell { get; } =
            GetDefinition<MetamagicOptionDefinition>("MetamagicQuickenedSpell");

        internal static MetamagicOptionDefinition MetamagicTwinnedSpell { get; } =
            GetDefinition<MetamagicOptionDefinition>("MetamagicTwinnedSpell");
    }

    internal static class RecipeDefinitions
    {
        internal static RecipeDefinition Recipe_Enchantment_BattleaxePunisher { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_BattleaxePunisher");

        internal static RecipeDefinition Recipe_Enchantment_BreastplateOfDeflection { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_BreastplateOfDeflection");

        internal static RecipeDefinition Recipe_Enchantment_DaggerFrostburn { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_DaggerFrostburn");

        internal static RecipeDefinition Recipe_Enchantment_DaggerOfAcuteness { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_DaggerOfAcuteness");

        internal static RecipeDefinition Recipe_Enchantment_DaggerOfSharpness { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_DaggerOfSharpness");

        internal static RecipeDefinition Recipe_Enchantment_DaggerSouldrinker { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_DaggerSouldrinker");

        internal static RecipeDefinition Recipe_Enchantment_GreatswordLightbringer { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_GreatswordLightbringer");

        internal static RecipeDefinition Recipe_Enchantment_HalfplateOfRobustness { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_HalfplateOfRobustness");

        internal static RecipeDefinition Recipe_Enchantment_HalfplateOfSturdiness { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_HalfplateOfSturdiness");

        internal static RecipeDefinition Recipe_Enchantment_LeatherArmorOfFlameDancing { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LeatherArmorOfFlameDancing");

        internal static RecipeDefinition Recipe_Enchantment_LeatherArmorOfSurvival { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LeatherArmorOfSurvival");

        internal static RecipeDefinition Recipe_Enchantment_LongbowLightbringer { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LongbowLightbringer");

        internal static RecipeDefinition Recipe_Enchantment_LongbowOfAcurracy { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LongbowOfAcurracy");

        internal static RecipeDefinition Recipe_Enchantment_LongsbowStormbow { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LongsbowStormbow");

        internal static RecipeDefinition Recipe_Enchantment_LongswordDragonblade { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LongswordDragonblade");

        internal static RecipeDefinition Recipe_Enchantment_LongswordFrostburn { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LongswordFrostburn");

        internal static RecipeDefinition Recipe_Enchantment_LongswordStormblade { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LongswordStormblade");

        internal static RecipeDefinition Recipe_Enchantment_LongswordWarden { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_LongswordWarden");

        internal static RecipeDefinition Recipe_Enchantment_MaceOfAcuteness { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_MaceOfAcuteness");

        internal static RecipeDefinition Recipe_Enchantment_MorningstarBearclaw { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_MorningstarBearclaw");

        internal static RecipeDefinition Recipe_Enchantment_MorningstarOfPower { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_MorningstarOfPower");

        internal static RecipeDefinition Recipe_Enchantment_RapierBlackAdder { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_RapierBlackAdder");

        internal static RecipeDefinition Recipe_Enchantment_RapierDoomblade { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_RapierDoomblade");

        internal static RecipeDefinition Recipe_Enchantment_RapierOfAcuteness { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_RapierOfAcuteness");

        internal static RecipeDefinition Recipe_Enchantment_ScaleMailOfIceDancing { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_ScaleMailOfIceDancing");

        internal static RecipeDefinition Recipe_Enchantment_ShortbowMedusa { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_ShortbowMedusa");

        internal static RecipeDefinition Recipe_Enchantment_ShortbowOfSharpshooting { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_ShortbowOfSharpshooting");

        internal static RecipeDefinition Recipe_Enchantment_ShortswordLightbringer { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_ShortswordLightbringer");

        internal static RecipeDefinition Recipe_Enchantment_ShortswordWhiteburn { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_ShortswordWhiteburn");

        internal static RecipeDefinition Recipe_Enchantment_ShortwordOfSharpness { get; } =
            GetDefinition<RecipeDefinition>("Recipe_Enchantment_ShortwordOfSharpness");
    }

    internal static class SchoolOfMagicDefinitions
    {
        internal static SchoolOfMagicDefinition SchoolAbjuration { get; } =
            GetDefinition<SchoolOfMagicDefinition>("SchoolAbjuration");

        internal static SchoolOfMagicDefinition SchoolConjuration { get; } =
            GetDefinition<SchoolOfMagicDefinition>("SchoolConjuration");

        internal static SchoolOfMagicDefinition SchoolDivination { get; } =
            GetDefinition<SchoolOfMagicDefinition>("SchoolDivination");

        internal static SchoolOfMagicDefinition SchoolEnchantment { get; } =
            GetDefinition<SchoolOfMagicDefinition>("SchoolEnchantment");

        internal static SchoolOfMagicDefinition SchoolEvocation { get; } =
            GetDefinition<SchoolOfMagicDefinition>("SchoolEvocation");

        internal static SchoolOfMagicDefinition SchoolIllusion { get; } =
            GetDefinition<SchoolOfMagicDefinition>("SchoolIllusion");

        internal static SchoolOfMagicDefinition SchoolNecromancy { get; } =
            GetDefinition<SchoolOfMagicDefinition>("SchoolNecromancy");

        internal static SchoolOfMagicDefinition SchoolTransmutation { get; } =
            GetDefinition<SchoolOfMagicDefinition>("SchoolTransmutation");
    }

    internal static class SkillDefinitions
    {
        internal static SkillDefinition Arcana { get; } =
            GetDefinition<SkillDefinition>("Arcana");

        internal static SkillDefinition Athletics { get; } =
            GetDefinition<SkillDefinition>("Athletics");

        internal static SkillDefinition History { get; } =
            GetDefinition<SkillDefinition>("History");

        internal static SkillDefinition Insight { get; } =
            GetDefinition<SkillDefinition>("Insight");

        internal static SkillDefinition Medecine { get; } =
            GetDefinition<SkillDefinition>("Medecine");

        internal static SkillDefinition Nature { get; } =
            GetDefinition<SkillDefinition>("Nature");

        internal static SkillDefinition Perception { get; } =
            GetDefinition<SkillDefinition>("Perception");

        internal static SkillDefinition Religion { get; } =
            GetDefinition<SkillDefinition>("Religion");

        internal static SkillDefinition SleightOfHand { get; } =
            GetDefinition<SkillDefinition>("SleightOfHand");

        internal static SkillDefinition Stealth { get; } =
            GetDefinition<SkillDefinition>("Stealth");

        internal static SkillDefinition Survival { get; } =
            GetDefinition<SkillDefinition>("Survival");
    }

    internal static class SlotTypeDefinitions
    {
        internal static SlotTypeDefinition ContainerSlot { get; } =
            GetDefinition<SlotTypeDefinition>("ContainerSlot");

        internal static SlotTypeDefinition MainHandSlot { get; } =
            GetDefinition<SlotTypeDefinition>("MainHandSlot");

        internal static SlotTypeDefinition OffHandSlot { get; } =
            GetDefinition<SlotTypeDefinition>("OffHandSlot");

        internal static SlotTypeDefinition TorsoSlot { get; } =
            GetDefinition<SlotTypeDefinition>("TorsoSlot");

    }

    internal static class SpellDefinitions
    {
        internal static SpellDefinition AcidSplash { get; } =
            GetDefinition<SpellDefinition>("AcidSplash");

        internal static SpellDefinition Aid { get; } =
            GetDefinition<SpellDefinition>("Aid");

        internal static SpellDefinition AnimalFriendship { get; } =
            GetDefinition<SpellDefinition>("AnimalFriendship");

        internal static SpellDefinition Bane { get; } =
            GetDefinition<SpellDefinition>("Bane");

        internal static SpellDefinition Banishment { get; } =
            GetDefinition<SpellDefinition>("Banishment");

        internal static SpellDefinition BeaconOfHope { get; } =
            GetDefinition<SpellDefinition>("BeaconOfHope");

        internal static SpellDefinition BestowCurse { get; } =
            GetDefinition<SpellDefinition>("BestowCurse");

        internal static SpellDefinition BlackTentacles { get; } =
            GetDefinition<SpellDefinition>("BlackTentacles");

        internal static SpellDefinition BladeBarrier { get; } =
            GetDefinition<SpellDefinition>("BladeBarrier");

        internal static SpellDefinition Bless { get; } =
            GetDefinition<SpellDefinition>("Bless");

        internal static SpellDefinition Blight { get; } =
            GetDefinition<SpellDefinition>("Blight");

        internal static SpellDefinition Blindness { get; } =
            GetDefinition<SpellDefinition>("Blindness");

        internal static SpellDefinition Blur { get; } =
            GetDefinition<SpellDefinition>("Blur");

        internal static SpellDefinition BrandingSmite { get; } =
            GetDefinition<SpellDefinition>("BrandingSmite");

        internal static SpellDefinition BurningHands { get; } =
            GetDefinition<SpellDefinition>("BurningHands");

        internal static SpellDefinition CallLightning { get; } =
            GetDefinition<SpellDefinition>("CallLightning");

        internal static SpellDefinition ChainLightning { get; } =
            GetDefinition<SpellDefinition>("ChainLightning");

        internal static SpellDefinition CharmPerson { get; } =
            GetDefinition<SpellDefinition>("CharmPerson");

        internal static SpellDefinition ChillTouch { get; } =
            GetDefinition<SpellDefinition>("ChillTouch");

        internal static SpellDefinition CloudKill { get; } =
            GetDefinition<SpellDefinition>("CloudKill");

        internal static SpellDefinition ColorSpray { get; } =
            GetDefinition<SpellDefinition>("ColorSpray");

        internal static SpellDefinition Command { get; } =
            GetDefinition<SpellDefinition>("Command");

        internal static SpellDefinition ConeOfCold { get; } =
            GetDefinition<SpellDefinition>("ConeOfCold");

        internal static SpellDefinition Confusion { get; } =
            GetDefinition<SpellDefinition>("Confusion");

        internal static SpellDefinition ConjureElemental { get; } =
            GetDefinition<SpellDefinition>("ConjureElemental");

        internal static SpellDefinition ConjureElementalAir { get; } =
            GetDefinition<SpellDefinition>("ConjureElementalAir");

        internal static SpellDefinition ConjureElementalFire { get; } =
            GetDefinition<SpellDefinition>("ConjureElementalFire");

        internal static SpellDefinition ConjureAnimalsOneBeast { get; } =
            GetDefinition<SpellDefinition>("ConjureAnimalsOneBeast");

        internal static SpellDefinition ConjureFey { get; } =
            GetDefinition<SpellDefinition>("ConjureFey");

        internal static SpellDefinition ConjureMinorElementals { get; } =
            GetDefinition<SpellDefinition>("ConjureMinorElementals");

        internal static SpellDefinition Contagion { get; } =
            GetDefinition<SpellDefinition>("Contagion");

        internal static SpellDefinition Counterspell { get; } =
            GetDefinition<SpellDefinition>("Counterspell");

        internal static SpellDefinition CreateFood { get; } =
            GetDefinition<SpellDefinition>("CreateFood");

        internal static SpellDefinition CureWounds { get; } =
            GetDefinition<SpellDefinition>("CureWounds");

        internal static SpellDefinition DancingLights { get; } =
            GetDefinition<SpellDefinition>("DancingLights");

        internal static SpellDefinition Darkness { get; } =
            GetDefinition<SpellDefinition>("Darkness");

        internal static SpellDefinition Darkvision { get; } =
            GetDefinition<SpellDefinition>("Darkvision");

        internal static SpellDefinition Daylight { get; } =
            GetDefinition<SpellDefinition>("Daylight");

        internal static SpellDefinition Dazzle { get; } =
            GetDefinition<SpellDefinition>("Dazzle");

        internal static SpellDefinition DeathWard { get; } =
            GetDefinition<SpellDefinition>("DeathWard");

        internal static SpellDefinition DetectMagic { get; } =
            GetDefinition<SpellDefinition>("DetectMagic");

        internal static SpellDefinition DimensionDoor { get; } =
            GetDefinition<SpellDefinition>("DimensionDoor");

        internal static SpellDefinition Disintegrate { get; } =
            GetDefinition<SpellDefinition>("Disintegrate");

        internal static SpellDefinition DispelEvilAndGood { get; } =
            GetDefinition<SpellDefinition>("DispelEvilAndGood");

        internal static SpellDefinition DispelMagic { get; } =
            GetDefinition<SpellDefinition>("DispelMagic");

        internal static SpellDefinition DominateBeast { get; } =
            GetDefinition<SpellDefinition>("DominateBeast");

        internal static SpellDefinition DominatePerson { get; } =
            GetDefinition<SpellDefinition>("DominatePerson");

        internal static SpellDefinition EnhanceAbility { get; } =
            GetDefinition<SpellDefinition>("EnhanceAbility");

        internal static SpellDefinition EnhanceAbilityBullsStrength { get; } =
            GetDefinition<SpellDefinition>("EnhanceAbilityBullsStrength");

        internal static SpellDefinition Entangle { get; } =
            GetDefinition<SpellDefinition>("Entangle");

        internal static SpellDefinition ExpeditiousRetreat { get; } =
            GetDefinition<SpellDefinition>("ExpeditiousRetreat");

        internal static SpellDefinition FaerieFire { get; } =
            GetDefinition<SpellDefinition>("FaerieFire");

        internal static SpellDefinition FalseLife { get; } =
            GetDefinition<SpellDefinition>("FalseLife");

        internal static SpellDefinition Fear { get; } =
            GetDefinition<SpellDefinition>("Fear");

        internal static SpellDefinition FeatherFall { get; } =
            GetDefinition<SpellDefinition>("FeatherFall");

        internal static SpellDefinition Fireball { get; } =
            GetDefinition<SpellDefinition>("Fireball");

        internal static SpellDefinition FireBolt { get; } =
            GetDefinition<SpellDefinition>("FireBolt");

        internal static SpellDefinition FireShield { get; } =
            GetDefinition<SpellDefinition>("FireShield");

        internal static SpellDefinition FlameBlade { get; } =
            GetDefinition<SpellDefinition>("FlameBlade");

        internal static SpellDefinition FlameStrike { get; } =
            GetDefinition<SpellDefinition>("FlameStrike");

        internal static SpellDefinition FlamingSphere { get; } =
            GetDefinition<SpellDefinition>("FlamingSphere");

        internal static SpellDefinition Fly { get; } =
            GetDefinition<SpellDefinition>("Fly");

        internal static SpellDefinition FogCloud { get; } =
            GetDefinition<SpellDefinition>("FogCloud");

        internal static SpellDefinition FreedomOfMovement { get; } =
            GetDefinition<SpellDefinition>("FreedomOfMovement");

        internal static SpellDefinition GiantInsect { get; } =
            GetDefinition<SpellDefinition>("GiantInsect");

        internal static SpellDefinition Goodberry { get; } =
            GetDefinition<SpellDefinition>("Goodberry");

        internal static SpellDefinition Grease { get; } =
            GetDefinition<SpellDefinition>("Grease");

        internal static SpellDefinition GreaterInvisibility { get; } =
            GetDefinition<SpellDefinition>("GreaterInvisibility");

        internal static SpellDefinition GreaterRestoration { get; } =
            GetDefinition<SpellDefinition>("GreaterRestoration");

        internal static SpellDefinition GuardianOfFaith { get; } =
            GetDefinition<SpellDefinition>("GuardianOfFaith");

        internal static SpellDefinition Guidance { get; } =
            GetDefinition<SpellDefinition>("Guidance");

        internal static SpellDefinition GuidingBolt { get; } =
            GetDefinition<SpellDefinition>("GuidingBolt");

        internal static SpellDefinition Haste { get; } =
            GetDefinition<SpellDefinition>("Haste");

        internal static SpellDefinition Heal { get; } =
            GetDefinition<SpellDefinition>("Heal");

        internal static SpellDefinition HealingWord { get; } =
            GetDefinition<SpellDefinition>("HealingWord");

        internal static SpellDefinition HeatMetal { get; } =
            GetDefinition<SpellDefinition>("HeatMetal");

        internal static SpellDefinition HellishRebuke { get; } =
            GetDefinition<SpellDefinition>("HellishRebuke");

        internal static SpellDefinition Heroism { get; } =
            GetDefinition<SpellDefinition>("Heroism");

        internal static SpellDefinition HideousLaughter { get; } =
            GetDefinition<SpellDefinition>("HideousLaughter");

        internal static SpellDefinition HoldMonster { get; } =
            GetDefinition<SpellDefinition>("HoldMonster");

        internal static SpellDefinition HoldPerson { get; } =
            GetDefinition<SpellDefinition>("HoldPerson");

        internal static SpellDefinition IceStorm { get; } =
            GetDefinition<SpellDefinition>("IceStorm");

        internal static SpellDefinition Identify { get; } =
            GetDefinition<SpellDefinition>("Identify");

        internal static SpellDefinition IdentifyCreatures { get; } =
            GetDefinition<SpellDefinition>("IdentifyCreatures");

        internal static SpellDefinition InflictWounds { get; } =
            GetDefinition<SpellDefinition>("InflictWounds");

        internal static SpellDefinition InsectPlague { get; } =
            GetDefinition<SpellDefinition>("InsectPlague");

        internal static SpellDefinition Invisibility { get; } =
            GetDefinition<SpellDefinition>("Invisibility");

        internal static SpellDefinition Jump { get; } =
            GetDefinition<SpellDefinition>("Jump");

        internal static SpellDefinition LesserRestoration { get; } =
            GetDefinition<SpellDefinition>("LesserRestoration");

        internal static SpellDefinition Levitate { get; } =
            GetDefinition<SpellDefinition>("Levitate");

        internal static SpellDefinition Light { get; } =
            GetDefinition<SpellDefinition>("Light");

        internal static SpellDefinition LightningBolt { get; } =
            GetDefinition<SpellDefinition>("LightningBolt");

        internal static SpellDefinition Longstrider { get; } =
            GetDefinition<SpellDefinition>("Longstrider");

        internal static SpellDefinition MagicMissile { get; } =
            GetDefinition<SpellDefinition>("MagicMissile");

        internal static SpellDefinition MagicWeapon { get; } =
            GetDefinition<SpellDefinition>("MagicWeapon");

        internal static SpellDefinition MassCureWounds { get; } =
            GetDefinition<SpellDefinition>("MassCureWounds");

        internal static SpellDefinition MassHealingWord { get; } =
            GetDefinition<SpellDefinition>("MassHealingWord");

        internal static SpellDefinition MindTwist { get; } =
            GetDefinition<SpellDefinition>("MindTwist");

        internal static SpellDefinition MistyStep { get; } =
            GetDefinition<SpellDefinition>("MistyStep");

        internal static SpellDefinition MoonBeam { get; } =
            GetDefinition<SpellDefinition>("MoonBeam");

        internal static SpellDefinition PassWithoutTrace { get; } =
            GetDefinition<SpellDefinition>("PassWithoutTrace");

        internal static SpellDefinition PhantasmalKiller { get; } =
            GetDefinition<SpellDefinition>("PhantasmalKiller");

        internal static SpellDefinition PoisonSpray { get; } =
            GetDefinition<SpellDefinition>("PoisonSpray");

        internal static SpellDefinition ProduceFlameHurl { get; } =
            GetDefinition<SpellDefinition>("ProduceFlameHurl");

        internal static SpellDefinition ProtectionFromEnergy { get; } =
            GetDefinition<SpellDefinition>("ProtectionFromEnergy");

        internal static SpellDefinition ProtectionFromEnergyAcid { get; } =
            GetDefinition<SpellDefinition>("ProtectionFromEnergyAcid");

        internal static SpellDefinition ProtectionFromEnergyCold { get; } =
            GetDefinition<SpellDefinition>("ProtectionFromEnergyCold");

        internal static SpellDefinition ProtectionFromEnergyFire { get; } =
            GetDefinition<SpellDefinition>("ProtectionFromEnergyFire");

        internal static SpellDefinition ProtectionFromEnergyLightning { get; } =
            GetDefinition<SpellDefinition>("ProtectionFromEnergyLightning");

        internal static SpellDefinition ProtectionFromEnergyThunder { get; } =
            GetDefinition<SpellDefinition>("ProtectionFromEnergyThunder");

        internal static SpellDefinition ProtectionFromEvilGood { get; } =
            GetDefinition<SpellDefinition>("ProtectionFromEvilGood");

        internal static SpellDefinition ProtectionFromPoison { get; } =
            GetDefinition<SpellDefinition>("ProtectionFromPoison");

        internal static SpellDefinition RayOfFrost { get; } =
            GetDefinition<SpellDefinition>("RayOfFrost");

        internal static SpellDefinition RemoveCurse { get; } =
            GetDefinition<SpellDefinition>("RemoveCurse");

        internal static SpellDefinition Resistance { get; } =
            GetDefinition<SpellDefinition>("Resistance");

        internal static SpellDefinition Revivify { get; } =
            GetDefinition<SpellDefinition>("Revivify");

        internal static SpellDefinition SacredFlame_B { get; } =
            GetDefinition<SpellDefinition>("SacredFlame_B");

        internal static SpellDefinition ScorchingRay { get; } =
            GetDefinition<SpellDefinition>("ScorchingRay");

        internal static SpellDefinition SeeInvisibility { get; } =
            GetDefinition<SpellDefinition>("SeeInvisibility");

        internal static SpellDefinition Shatter { get; } =
            GetDefinition<SpellDefinition>("Shatter");

        internal static SpellDefinition Shield { get; } =
            GetDefinition<SpellDefinition>("Shield");

        internal static SpellDefinition Shillelagh { get; } =
            GetDefinition<SpellDefinition>("Shillelagh");

        internal static SpellDefinition Shine { get; } =
            GetDefinition<SpellDefinition>("Shine");

        internal static SpellDefinition ShockingGrasp { get; } =
            GetDefinition<SpellDefinition>("ShockingGrasp");

        internal static SpellDefinition Sleep { get; } =
            GetDefinition<SpellDefinition>("Sleep");

        internal static SpellDefinition SleetStorm { get; } =
            GetDefinition<SpellDefinition>("SleetStorm");

        internal static SpellDefinition Slow { get; } =
            GetDefinition<SpellDefinition>("Slow");

        internal static SpellDefinition SpareTheDying { get; } =
            GetDefinition<SpellDefinition>("SpareTheDying");

        internal static SpellDefinition Sparkle { get; } =
            GetDefinition<SpellDefinition>("Sparkle");

        internal static SpellDefinition SpiderClimb { get; } =
            GetDefinition<SpellDefinition>("SpiderClimb");

        internal static SpellDefinition SpikeGrowth { get; } =
            GetDefinition<SpellDefinition>("SpikeGrowth");

        internal static SpellDefinition SpiritualWeapon { get; } =
            GetDefinition<SpellDefinition>("SpiritualWeapon");

        internal static SpellDefinition StinkingCloud { get; } =
            GetDefinition<SpellDefinition>("StinkingCloud");

        internal static SpellDefinition Stoneskin { get; } =
            GetDefinition<SpellDefinition>("Stoneskin");

        internal static SpellDefinition Thunderwave { get; } =
            GetDefinition<SpellDefinition>("Thunderwave");

        internal static SpellDefinition TrueSeeing { get; } =
            GetDefinition<SpellDefinition>("TrueSeeing");

        internal static SpellDefinition TrueStrike { get; } =
            GetDefinition<SpellDefinition>("TrueStrike");

        internal static SpellDefinition VampiricTouch { get; } =
            GetDefinition<SpellDefinition>("VampiricTouch");

        internal static SpellDefinition VenomousSpike { get; } =
            GetDefinition<SpellDefinition>("VenomousSpike");

        internal static SpellDefinition WallOfFire { get; } =
            GetDefinition<SpellDefinition>("WallOfFire");

        internal static SpellDefinition WallOfForce { get; } =
            GetDefinition<SpellDefinition>("WallOfForce");

        internal static SpellDefinition WallOfThornsWallLine { get; } =
            GetDefinition<SpellDefinition>("WallOfThornsWallLine");

        internal static SpellDefinition WallOfThornsWallRing { get; } =
            GetDefinition<SpellDefinition>("WallOfThornsWallRing");

        internal static SpellDefinition WardingBond { get; } =
            GetDefinition<SpellDefinition>("WardingBond");

        internal static SpellDefinition WindWall { get; } =
            GetDefinition<SpellDefinition>("WindWall");

    }

    internal static class SpellListDefinitions
    {
        internal static SpellListDefinition SpellListAllCantrips { get; } =
            GetDefinition<SpellListDefinition>("SpellListAllCantrips");

        internal static SpellListDefinition SpellListAllSpells { get; } =
            GetDefinition<SpellListDefinition>("SpellListAllSpells");

        internal static SpellListDefinition SpellListBard { get; } =
            GetDefinition<SpellListDefinition>("SpellListBard");

        internal static SpellListDefinition SpellListCleric { get; } =
            GetDefinition<SpellListDefinition>("SpellListCleric");

        internal static SpellListDefinition SpellListDruid { get; } =
            GetDefinition<SpellListDefinition>("SpellListDruid");

        internal static SpellListDefinition SpellListPaladin { get; } =
            GetDefinition<SpellListDefinition>("SpellListPaladin");

        internal static SpellListDefinition SpellListRanger { get; } =
            GetDefinition<SpellListDefinition>("SpellListRanger");

        internal static SpellListDefinition SpellListSorcerer { get; } =
            GetDefinition<SpellListDefinition>("SpellListSorcerer");

        internal static SpellListDefinition SpellListWarlock { get; } =
            GetDefinition<SpellListDefinition>("SpellListWarlock");

        internal static SpellListDefinition SpellListWizard { get; } =
            GetDefinition<SpellListDefinition>("SpellListWizard");
    }

    internal static class ToolTypeDefinitions
    {
        internal static ToolTypeDefinition ArtisanToolSmithToolsType { get; } =
            GetDefinition<ToolTypeDefinition>("ArtisanToolSmithToolsType");

        internal static ToolTypeDefinition DisguiseKitType { get; } =
            GetDefinition<ToolTypeDefinition>("DisguiseKitType");

        internal static ToolTypeDefinition EnchantingToolType { get; } =
            GetDefinition<ToolTypeDefinition>("EnchantingToolType");

        internal static ToolTypeDefinition HerbalismKitType { get; } =
            GetDefinition<ToolTypeDefinition>("HerbalismKitType");

        internal static ToolTypeDefinition PoisonersKitType { get; } =
            GetDefinition<ToolTypeDefinition>("PoisonersKitType");

        internal static ToolTypeDefinition ScrollKitType { get; } =
            GetDefinition<ToolTypeDefinition>("ScrollKitType");

        internal static ToolTypeDefinition ThievesToolsType { get; } =
            GetDefinition<ToolTypeDefinition>("ThievesToolsType");
    }

    internal static class WeaponCategoryDefinitions
    {
        internal static WeaponCategoryDefinition MartialWeaponCategory { get; } =
            GetDefinition<WeaponCategoryDefinition>("MartialWeaponCategory");
    }

    internal static class WeaponTypeDefinitions
    {
        internal static WeaponTypeDefinition ClubType { get; } =
            GetDefinition<WeaponTypeDefinition>("ClubType");

        internal static WeaponTypeDefinition GreataxeType { get; } =
            GetDefinition<WeaponTypeDefinition>("GreataxeType");

        internal static WeaponTypeDefinition HeavyCrossbowType { get; } =
            GetDefinition<WeaponTypeDefinition>("HeavyCrossbowType");

        internal static WeaponTypeDefinition LightCrossbowType { get; } =
            GetDefinition<WeaponTypeDefinition>("LightCrossbowType");

        internal static WeaponTypeDefinition LongbowType { get; } =
            GetDefinition<WeaponTypeDefinition>("LongbowType");

        internal static WeaponTypeDefinition MaulType { get; } =
            GetDefinition<WeaponTypeDefinition>("MaulType");

        internal static WeaponTypeDefinition QuarterstaffType { get; } =
            GetDefinition<WeaponTypeDefinition>("QuarterstaffType");

        internal static WeaponTypeDefinition RapierType { get; } =
            GetDefinition<WeaponTypeDefinition>("RapierType");

        internal static WeaponTypeDefinition ShortbowType { get; } =
            GetDefinition<WeaponTypeDefinition>("ShortbowType");

        internal static WeaponTypeDefinition ShortswordType { get; } =
            GetDefinition<WeaponTypeDefinition>("ShortswordType");

        internal static WeaponTypeDefinition SpearType { get; } =
            GetDefinition<WeaponTypeDefinition>("SpearType");

        internal static WeaponTypeDefinition UnarmedStrikeType { get; } =
            GetDefinition<WeaponTypeDefinition>("UnarmedStrikeType");
    }
}
