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

    public class ManaSickPotion : ModItem
	{
       // Mod Calamity = ModLoader.GetMod("CalamityMod");

        public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.maxStack = 30;
			item.rare = 1;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 2;
			item.UseSound = SoundID.Item3;
			item.consumable = true;
		}
       /* public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[0].overrideColor = new Color(0, 204, 102);
        } */
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sickness immunity Potion");
            Tooltip.SetDefault("Grants immunity to Mana Sickness\n" +
            "8 Minutes duration\n");
        }

		public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("ManaSickImmune"), 32000); //999999999
            return true;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(126, 1);
            recipe.AddIngredient(ItemID.Moonglow, 5);
            recipe.AddIngredient(ItemID.Daybloom, 5);
            recipe.AddIngredient(ItemID.Deathweed, 5);
            recipe.AddIngredient(75, 5);
            recipe.AddTile(13); //Placed bottle
            recipe.SetResult(this);
            recipe.AddRecipe();

      /*      if (Calamity != null)
            {
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod"), "BloodOrb", 20);
                recipe.AddIngredient(126, 1);
                recipe.AddTile(355); //alchemy station 355 , 13 placed bottle 
                recipe.SetResult(this);
                recipe.AddRecipe();
            } */
        }
	}
}
