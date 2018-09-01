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

namespace ItemsBuffs.Items.Potions
{

    public class ChaosPotion : ModItem
	{
        public override void SetDefaults()
		{
			item.width = 20;
			item.height = 40;
			item.maxStack = 30;
			item.rare = 0;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 2;
			item.UseSound = SoundID.Item3;
			item.consumable = true;
		}
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[0].overrideColor = new Color(255, 255, 0);
        }
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Light Charm Potion");
            Tooltip.SetDefault("immune to chaos State\n" +
            "8 Minutes duration\n");
        }

		public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("ChaosStateImmune"), 32000); //999999999
            return true;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(126, 1);
            recipe.AddIngredient(ItemID.PixieDust, 20);
            recipe.AddIngredient(ItemID.UnicornHorn, 1);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddIngredient(75, 1);
            recipe.AddTile(355); //Placed Alchemy table
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
