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
	public class SpectreHood : GlobalItem
	{

        public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().SpectreHood == false;
		}
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.SpectreHood)
            {
                //remove the tooltip
             //   tooltips.RemoveAll(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                //actually, the hood's old statics is increased damage and crit chance by 10%.
                
                TooltipLine line = tooltips.FirstOrDefault(x => x.Name == "Tooltip0" && x.mod == "Terraria");
                if (line != null)
                {
                    line.text = "10% increased magic damage and critical strike chance.";
                }
                
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == ItemID.SpectreHood)
            {
            player.magicDamage += 0.50f; // old was 0.40f
            player.magicCrit += 10;

            }
        }
	}
}