﻿using HarmonyLib;
using SRLE.Components;
using UnityEngine;

namespace SRLE.Patches;

[HarmonyPatch(typeof(KillOnTrigger), nameof(KillOnTrigger.OnTriggerEnter))]
public static class KillOnTriggerOnTriggerEnter
{
    public static bool Prefix(Collider collider)
    {
        if (PhysicsUtil.IsPlayerMainCollider(collider))
        {
            if (SRLECamera.Instance != null && SRLECamera.Instance.isActiveAndEnabled && SRLEMod.CurrentMode == SRLEMod.Mode.BUILD)
            {
                return false;
            }
        }

        return false;
    }
}