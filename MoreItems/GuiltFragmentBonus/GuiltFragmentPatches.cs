﻿using Framework.Managers;
using Gameplay.GameControllers.Penitent.Effects;
using HarmonyLib;

namespace MoreItems.GuiltFragmentBonus
{
    [HarmonyPatch(typeof(GuiltDropRecover), "GiveGuiltBonus")]
    class GuiltDrop_GiveBonus_Patch
    {
        public static void Postfix()
        {
            if (GuiltFragmentEffect.Active)
            {
                Main.Items.Log("RB502: Increasing guilt drop bonus");
                Core.Logic.Penitent.Stats.Life.SetToCurrentMax();
                Core.Logic.Penitent.Stats.Fervour.SetToCurrentMax();
            }
        }
    }
}
