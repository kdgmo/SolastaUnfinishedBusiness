﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using SolastaUnfinishedBusiness.Api.Helpers;
using TA;

namespace SolastaUnfinishedBusiness.CustomUI;

internal static class ReachMeleeTargeting
{
    // Replaces call to `FindBestActionDestination` with custom method that respects attack mode's reach
    // Needed for reach melee
    internal static IEnumerable<CodeInstruction> ApplyCursorLocationIsValidAttackTranspile(
        IEnumerable<CodeInstruction> instructions)
    {
        var method = typeof(ReachMeleeTargeting)
            .GetMethod("FindBestActionDestination", BindingFlags.Static | BindingFlags.NonPublic);

        return instructions.ReplaceCode(
            instruction => instruction.opcode == OpCodes.Call &&
                           instruction.operand.ToString().Contains("FindBestActionDestination"),
            -1,
            0,
            new CodeInstruction(OpCodes.Ldarg_0),
            new CodeInstruction(OpCodes.Ldloc_1),
            new CodeInstruction(OpCodes.Call, method));
    }

    // Used in `ApplyCursorLocationIsValidAttackTranspile`
    // ReSharper disable once UnusedMember.Global
    internal static bool FindBestActionDestination(
        GameLocationCharacter actor,
        GameLocationCharacter target,
        ref int3 actorPosition,
        CursorLocationBattleFriendlyTurn cursor,
        RulesetAttackMode attackMode)
    {
        var reachRange = attackMode.ReachRange;
        var validDestinations = cursor.validDestinations;

        if (cursor.BattleService.IsWithinXCells(actor, target, reachRange) || validDestinations.Empty())
        {
            return true;
        }

        var battleBoundingBox = target.LocationBattleBoundingBox;

        battleBoundingBox.Inflate(reachRange);

        var foundDestination = false;

        var current = new GameLocationCharacterDefinitions.PathStep { moveCost = 99999 };
        var distance = (current.position - actorPosition).magnitudeSqr;

        foreach (var destination in validDestinations
                     .Where(destination => battleBoundingBox.Contains(destination.position)))
        {
            bool better;

            if (foundDestination && destination.moveCost >= current.moveCost)
            {
                if (destination.moveCost == current.moveCost)
                {
                    better = (destination.position - actorPosition).magnitudeSqr < distance;
                }
                else
                {
                    better = false;
                }
            }
            else
            {
                better = true;
            }

            if (!better)
            {
                continue;
            }

            current = destination;
            distance = (current.position - actorPosition).magnitudeSqr;
            foundDestination = true;
        }

        if (foundDestination)
        {
            actorPosition = current.position;
        }

        return foundDestination;
    }
}
