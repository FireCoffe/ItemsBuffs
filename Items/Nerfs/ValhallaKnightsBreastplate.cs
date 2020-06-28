using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using Terraria.DataStructures;
using Terraria.Localization;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using static Terraria.ModLoader.ModContent;
using ItemsBuffs.Items;

namespace ItemsBuffs.Items.Nerfs
{
	public class ValhallaKnightsBreastplate : GlobalItem
	{

        public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().ValhallaKnightsBreastplate;
		}
      

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == 3872)
            {
            player.lifeRegen += 16;

            }
        }
	}
}