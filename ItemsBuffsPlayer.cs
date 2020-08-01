using ItemsBuffs.Buffs;
using ItemsBuffs.Items;
using ItemsBuffs.Items.Tools;
using ItemsBuffs.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

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
						ItemsBuffsPlayer clone = clientClone as ItemsBuffsPlayer;
        }
	

    }
}