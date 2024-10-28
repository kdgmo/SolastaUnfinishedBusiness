﻿using System;
using System.Diagnostics;
using SolastaUnfinishedBusiness.Api.ModKit;
using SolastaUnfinishedBusiness.Models;
using SolastaUnfinishedBusiness.Subclasses;

namespace SolastaUnfinishedBusiness.Displays;

internal static class ToolsDisplay
{
    private static string ExportFileName { get; set; } =
        ServiceRepository.GetService<INetworkingService>().GetUserName();

    internal static void DisplayGameplay()
    {
        DisplayGeneral();
        UI.Label();
        DisplayMultiplayer();
        UI.Label();
        DisplayOneDnd();
        UI.Label();
        DisplayTabletop();
        UI.Label();
    }

    private static void DisplayGeneral()
    {
        UI.Label();

        using (UI.HorizontalScope())
        {
            UI.ActionButton(Gui.Localize("ModUi/&Update"), () => UpdateContext.UpdateMod(),
                UI.Width(195f));
            UI.ActionButton(Gui.Localize("ModUi/&Rollback"), UpdateContext.DisplayRollbackMessage,
                UI.Width(195f));
            UI.ActionButton(Gui.Localize("ModUi/&Changelog"), UpdateContext.OpenChangeLog,
                UI.Width(195f));
        }

        UI.Label();

        var toggle = Main.Settings.EnablePcgRandom;
        if (UI.Toggle(Gui.Localize("ModUi/&EnablePcgRandom"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnablePcgRandom = toggle;
        }

        toggle = Main.Settings.EnableCustomPortraits;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableCustomPortraits"), ref toggle))
        {
            Main.Settings.EnableCustomPortraits = toggle;
        }

        if (Main.Settings.EnableCustomPortraits)
        {
            UI.Label();

            UI.ActionButton(Gui.Localize("ModUi/&PortraitsOpenFolder"), () =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = PortraitsContext.PortraitsFolder, UseShellExecute = true, Verb = "open"
                });
            }, UI.Width(292f));

            UI.Label();
            UI.Label(Gui.Localize("ModUi/&EnableCustomPortraitsHelp"));
        }

        UI.Label();

        toggle = Main.Settings.DisableMultilineSpellOffering;
        if (UI.Toggle(Gui.Localize("ModUi/&DisableMultilineSpellOffering"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.DisableMultilineSpellOffering = toggle;
        }

        toggle = Main.Settings.DisableUnofficialTranslations;
        if (UI.Toggle(Gui.Localize("ModUi/&DisableUnofficialTranslations"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.DisableUnofficialTranslations = toggle;
        }

        if (!Gui.GameCampaign)
        {
            return;
        }

        UI.Label();

        var gameCampaign = Gui.GameCampaign;

        if (!gameCampaign)
        {
            return;
        }

        UI.Label();

        using (UI.HorizontalScope())
        {
            UI.Label(Gui.Localize("ModUi/&IncreaseGameTimeBy"), UI.Width(300f));
            UI.ActionButton("1 hour", () => gameCampaign.UpdateTime(60 * 60), UI.Width(100f));
            UI.ActionButton("6 hours", () => gameCampaign.UpdateTime(60 * 60 * 6), UI.Width(100f));
            UI.ActionButton("12 hours", () => gameCampaign.UpdateTime(60 * 60 * 12), UI.Width(100f));
            UI.ActionButton("24 hours", () => gameCampaign.UpdateTime(60 * 60 * 24), UI.Width(100f));
        }
    }

    private static void DisplayMultiplayer()
    {
        var toggle = Main.Settings.DisplayMultiplayerToggle;
        if (UI.DisclosureToggle(Gui.Localize("ModUi/&Multiplayer"), ref toggle, 200))
        {
            Main.Settings.DisplayMultiplayerToggle = toggle;
        }

        if (!Main.Settings.DisplayMultiplayerToggle)
        {
            return;
        }

        UI.Label(Gui.Localize("ModUi/&SettingsHelp"));
        UI.Label();

        using (UI.HorizontalScope())
        {
            UI.ActionButton(Gui.Localize("ModUi/&SettingsExport"), () =>
            {
                Main.SaveSettings(ExportFileName);
            }, UI.Width(144f));

            UI.ActionButton(Gui.Localize("ModUi/&SettingsRemove"), () =>
            {
                Main.RemoveSettings(ExportFileName);
            }, UI.Width(144f));

            var text = ExportFileName;

            UI.ActionTextField(ref text, String.Empty, s => { ExportFileName = s; }, null, UI.Width(144f));
        }

        using (UI.HorizontalScope())
        {
            UI.ActionButton(Gui.Localize("ModUi/&SettingsRefresh"), Main.LoadSettingFilenames, UI.Width(144f));
            UI.ActionButton(Gui.Localize("ModUi/&SettingsOpenFolder"), () =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = Main.SettingsFolder, UseShellExecute = true, Verb = "open"
                });
            }, UI.Width(292f));
        }

        if (Main.SettingsFiles.Length == 0)
        {
            return;
        }

        UI.Label();
        UI.Label(Gui.Localize("ModUi/&SettingsLoad"));
        UI.Label();

        var intValue = -1;
        if (UI.SelectionGrid(ref intValue, Main.SettingsFiles, Main.SettingsFiles.Length, 4, UI.Width(440f)))
        {
            Main.LoadSettings(Main.SettingsFiles[intValue]);
        }
    }

    private static void DisplayOneDnd()
    {
        var toggle = Main.Settings.DisplayOneDndToggle;
        if (UI.DisclosureToggle(Gui.Localize("ModUi/&OneDnd"), ref toggle, 200))
        {
            Main.Settings.DisplayOneDndToggle = toggle;
        }

        if (!Main.Settings.DisplayOneDndToggle)
        {
            return;
        }

        UI.Label();

        toggle = Main.Settings.EnableSurprisedToEnforceDisadvantage;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableSurprisedToEnforceDisadvantage"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnableSurprisedToEnforceDisadvantage = toggle;
            SrdAndHouseRulesContext.SwitchOneDndSurprisedEnforceDisadvantage();
        }

        UI.Label();

        toggle = Main.Settings.OneDndHealingPotionBonusAction;
        if (UI.Toggle(Gui.Localize("ModUi/&OneDndHealingPotionBonusAction"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.OneDndHealingPotionBonusAction = toggle;
            SrdAndHouseRulesContext.SwitchOneDndHealingPotionBonusAction();
        }

        UI.Label();

        toggle = Main.Settings.EnablePaladinSpellCastingAtLevel1;
        if (UI.Toggle(Gui.Localize("ModUi/&EnablePaladinSpellCastingAtLevel1"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnablePaladinSpellCastingAtLevel1 = toggle;
            SrdAndHouseRulesContext.SwitchOneDndPaladinLearnSpellCastingAtOne();
        }

        toggle = Main.Settings.EnableRangerSpellCastingAtLevel1;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableRangerSpellCastingAtLevel1"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnableRangerSpellCastingAtLevel1 = toggle;
            SrdAndHouseRulesContext.SwitchOneDndRangerLearnSpellCastingAtOne();
        }

        toggle = Main.Settings.EnableWizardToLearnSchoolAtLevel3;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableWizardToLearnSchoolAtLevel3"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnableWizardToLearnSchoolAtLevel3 = toggle;
            SrdAndHouseRulesContext.SwitchOneDndWizardSchoolOfMagicLearningLevel();
        }

        UI.Label();

        toggle = Main.Settings.EnableOneDndHealingSpellsBuf;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableOneDndHealingSpellsBuf"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnableOneDndHealingSpellsBuf = toggle;
            SrdAndHouseRulesContext.SwitchOneDndHealingSpellsBuf();
        }

        UI.Label();

        toggle = Main.Settings.SwapEvocationPotentCantripAndSculptSpell;
        // ReSharper disable once InvertIf
        if (UI.Toggle(Gui.Localize("ModUi/&SwapEvocationPotentCantripAndSculptSpell"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.SwapEvocationPotentCantripAndSculptSpell = toggle;
            WizardEvocation.SwapEvocationPotentCantripAndSculptSpell();
        }
    }

    private static void DisplayTabletop()
    {
        var toggle = Main.Settings.DisplayTabletopToggle;
        if (UI.DisclosureToggle(Gui.Localize("ModUi/&Tabletop"), ref toggle, 200))
        {
            Main.Settings.DisplayTabletopToggle = toggle;
        }

        if (!Main.Settings.DisplayTabletopToggle)
        {
            return;
        }

        UI.Label();

        toggle = Main.Settings.EnableProneAction;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableProneAction"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnableProneAction = toggle;
            CharacterContext.SwitchProneAction();
        }

        toggle = Main.Settings.EnableGrappleAction;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableGrappleAction"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnableGrappleAction = toggle;
            GrappleContext.SwitchGrappleAction();
        }

        toggle = Main.Settings.EnableHelpAction;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableHelpAction"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnableHelpAction = toggle;
            CharacterContext.SwitchHelpPower();
        }

        toggle = Main.Settings.EnableUnarmedMainAttackAction;
        if (UI.Toggle(Gui.Localize(Gui.Localize("ModUi/&EnableUnarmedMainAttackAction")), ref toggle,
                UI.AutoWidth()))
        {
            Main.Settings.EnableUnarmedMainAttackAction = toggle;
        }

        UI.Label();

        toggle = Main.Settings.UseOfficialLightingObscurementAndVisionRules;
        if (UI.Toggle(Gui.Localize("ModUi/&UseOfficialObscurementRules"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.UseOfficialLightingObscurementAndVisionRules = toggle;
            Main.Settings.OfficialObscurementRulesInvisibleCreaturesCanBeTarget = toggle;
            Main.Settings.OfficialObscurementRulesCancelAdvDisPairs = toggle;
            Main.Settings.OfficialObscurementRulesHeavilyObscuredAsProjectileBlocker = false;
            Main.Settings.OfficialObscurementRulesMagicalDarknessAsProjectileBlocker = false;
            Main.Settings.OfficialObscurementRulesTweakMonsters = toggle;
            LightingAndObscurementContext.SwitchOfficialObscurementRules();
        }

        if (Main.Settings.UseOfficialLightingObscurementAndVisionRules)
        {
            UI.Label(Gui.Localize("ModUi/&UseOfficialObscurementRulesHelp"));

            toggle = Main.Settings.OfficialObscurementRulesInvisibleCreaturesCanBeTarget;
            if (UI.Toggle(Gui.Localize("ModUi/&OfficialObscurementRulesInvisibleCreaturesCanBeTarget"), ref toggle,
                    UI.AutoWidth()))
            {
                Main.Settings.OfficialObscurementRulesInvisibleCreaturesCanBeTarget = toggle;
            }

            toggle = Main.Settings.OfficialObscurementRulesCancelAdvDisPairs;
            if (UI.Toggle(Gui.Localize("ModUi/&OfficialObscurementRulesCancelAdvDisPairs"), ref toggle,
                    UI.AutoWidth()))
            {
                Main.Settings.OfficialObscurementRulesCancelAdvDisPairs = toggle;
            }

            toggle = Main.Settings.OfficialObscurementRulesTweakMonsters;
            if (UI.Toggle(Gui.Localize("ModUi/&OfficialObscurementRulesTweakMonsters"), ref toggle, UI.AutoWidth()))
            {
                Main.Settings.OfficialObscurementRulesTweakMonsters = toggle;
                LightingAndObscurementContext.SwitchMonstersOnObscurementRules();
            }

            if (Main.Settings.OfficialObscurementRulesTweakMonsters)
            {
                UI.Label(Gui.Localize("ModUi/&OfficialObscurementRulesTweakMonstersHelp"));
            }
        }

        UI.Label();


        toggle = Main.Settings.KeepStealthOnHeroIfPerceivedDuringSurpriseAttack;
        if (UI.Toggle(Gui.Localize("ModUi/&KeepStealthOnHeroIfPerceivedDuringSurpriseAttack"), ref toggle,
                UI.AutoWidth()))
        {
            Main.Settings.KeepStealthOnHeroIfPerceivedDuringSurpriseAttack = toggle;
        }

        toggle = Main.Settings.StealthDoesNotBreakWithSubtle;
        if (UI.Toggle(Gui.Localize("ModUi/&StealthDoesNotBreakWithSubtle"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.StealthDoesNotBreakWithSubtle = toggle;
        }

        UI.Label();

        toggle = Main.Settings.StealthBreaksWhenAttackHits;
        if (UI.Toggle(Gui.Localize("ModUi/&StealthBreaksWhenAttackHits"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.StealthBreaksWhenAttackHits = toggle;
        }

        toggle = Main.Settings.StealthBreaksWhenAttackMisses;
        if (UI.Toggle(Gui.Localize("ModUi/&StealthBreaksWhenAttackMisses"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.StealthBreaksWhenAttackMisses = toggle;
        }

        toggle = Main.Settings.StealthBreaksWhenCastingVerbose;
        if (UI.Toggle(Gui.Localize("ModUi/&StealthBreaksWhenCastingVerbose"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.StealthBreaksWhenCastingVerbose = toggle;
        }

        UI.Label();

        toggle = Main.Settings.AccountForAllDiceOnSavageAttack;
        if (UI.Toggle(Gui.Localize("ModUi/&AccountForAllDiceOnSavageAttack"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.AccountForAllDiceOnSavageAttack = toggle;
        }

        toggle = Main.Settings.AddDexModifierToEnemiesInitiativeRoll;
        if (UI.Toggle(Gui.Localize("ModUi/&AddDexModifierToEnemiesInitiativeRoll"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.AddDexModifierToEnemiesInitiativeRoll = toggle;
            Main.Settings.EnemiesAlwaysRollInitiative = toggle;
        }

        if (Main.Settings.AddDexModifierToEnemiesInitiativeRoll)
        {
            toggle = Main.Settings.EnemiesAlwaysRollInitiative;
            if (UI.Toggle(Gui.Localize("ModUi/&EnemiesAlwaysRollInitiative"), ref toggle, UI.AutoWidth()))
            {
                Main.Settings.EnemiesAlwaysRollInitiative = toggle;
            }
        }

        UI.Label();

        toggle = Main.Settings.EnablePullPushOnVerticalDirection;
        if (UI.Toggle(Gui.Localize("ModUi/&EnablePullPushOnVerticalDirection"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnablePullPushOnVerticalDirection = toggle;
            if (!toggle)
            {
                Main.Settings.ModifyGravitySlam = false;
                SrdAndHouseRulesContext.ToggleGravitySlamModification();
            }
        }

        toggle = Main.Settings.FullyControlConjurations;
        if (UI.Toggle(Gui.Localize("ModUi/&FullyControlConjurations"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.FullyControlConjurations = toggle;
            SrdAndHouseRulesContext.SwitchFullyControlConjurations();
        }

        UI.Label();

        toggle = Main.Settings.EnableTeleportToRemoveRestrained;
        if (UI.Toggle(Gui.Localize("ModUi/&EnableTeleportToRemoveRestrained"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.EnableTeleportToRemoveRestrained = toggle;
        }

        UI.Label();

        toggle = Main.Settings.ColdResistanceAlsoGrantsImmunityToChilledCondition;
        if (UI.Toggle(Gui.Localize("ModUi/&ColdResistanceAlsoGrantsImmunityToChilledCondition"), ref toggle,
                UI.AutoWidth()))
        {
            Main.Settings.ColdResistanceAlsoGrantsImmunityToChilledCondition = toggle;
            SrdAndHouseRulesContext.SwitchColdResistanceAndImmunityAlsoGrantsWeatherImmunity();
        }

        toggle = Main.Settings.ColdImmunityAlsoGrantsImmunityToChilledAndFrozenCondition;
        if (UI.Toggle(Gui.Localize("ModUi/&ColdImmunityAlsoGrantsImmunityToChilledAndFrozenCondition"), ref toggle,
                UI.AutoWidth()))
        {
            Main.Settings.ColdImmunityAlsoGrantsImmunityToChilledAndFrozenCondition = toggle;
            SrdAndHouseRulesContext.SwitchColdResistanceAndImmunityAlsoGrantsWeatherImmunity();
        }

        UI.Label();

        toggle = Main.Settings.UseOfficialFoodRationsWeight;
        if (UI.Toggle(Gui.Localize("ModUi/&UseOfficialFoodRationsWeight"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.UseOfficialFoodRationsWeight = toggle;
            SrdAndHouseRulesContext.SwitchOfficialFoodRationsWeight();
        }

        toggle = Main.Settings.FixRingOfRegenerationHealRate;
        // ReSharper disable once InvertIf
        if (UI.Toggle(Gui.Localize("ModUi/&FixRingOfRegenerationHealRate"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.FixRingOfRegenerationHealRate = toggle;
            SrdAndHouseRulesContext.SwitchRingOfRegenerationHealRate();
        }

        UI.Label();

        toggle = Main.Settings.UseOfficialSmallRacesDisWithHeavyWeapons;
        if (UI.Toggle(Gui.Localize("ModUi/&UseOfficialSmallRacesDisWithHeavyWeapons"), ref toggle, UI.AutoWidth()))
        {
            Main.Settings.UseOfficialSmallRacesDisWithHeavyWeapons = toggle;
        }
    }
}
