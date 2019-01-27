using Terraria;
using Terraria.ModLoader;
using Terraria.GameInput;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.UI;
using System;
using Terraria.ModLoader.IO;

namespace ItemsBuffs
{
    public class ItemsBuffsPlayer : ModPlayer
    {

        public bool OrbofLight = false;

        public override void ResetEffects()
        {
            OrbofLight = false;


        }
        public override void clientClone(ModPlayer clientClone)
        {

        }

    }
}