﻿using ModKit;
using System.Collections.Generic;

namespace SolastaCommunityExpansion.Viewers.Displays
{
    internal static class CreditsDisplay
    {
        internal static readonly Dictionary<string, string> CreditsTable = new Dictionary<string, string>
        {
            { "ChrisJohnDigital".orange().bold(), "head developer, crafting, faction relations, feats, fighting styles, items, subclasses, progression" },
            { "Zappastuff", "mod UI, integration, adventure log, dungeon maker, encounters, epic points, inventory sorting, level 20, party size, respec, surprise rules, tools" },
            { "ImpPhil", "adv/dis rules, conjurations control, auto-equip, monster's health, pause UI, stocks prices, no attunement, xp scaling, character export, save by location, combat camera" },
            { "DubhHerder", "Crafty Feats migration, bug models replacement" },
            { "View619", "Darkvision, Superior Dark Vision" },
            { "SilverGriffon", "PickPocket, lore friendly names, crafty feats, face unlocks, sylvan armor unlock, empress garb skins, arcane foci items, belt of dwarvenkin, merchants" },
            { "Boofat", "alwaysAlt" },
            { "Myztikrice", "faster time scale" },
            { "AceHigh", "Power Attack, Reckless Fury, no identification, Tactician subclass" },
            { "ElAntonious", "Torchbearer and Dual Flurry, Arcanist subclass" },
            { "Scarlex", "Royal Knight subclass" },
            { "RedOrca", "Path of Light subclass" },
            { "Narria", "modKit creator, developer" }
        };

        internal static void DisplayCredits()
        {
            UI.Div();
            UI.Label("");
            UI.Label("Credits:".yellow());
            UI.Label("");

            foreach (var kvp in CreditsTable)
            {
                using (UI.HorizontalScope())
                {
                    UI.Label(kvp.Key.orange(), UI.Width(110));
                    UI.Label(kvp.Value, UI.Width(500));
                }
            }
            UI.Label("");
        }
    }
}
