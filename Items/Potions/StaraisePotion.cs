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
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Potions
{

    public class StaraisePotion : ModItem
	{
    /*    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().SP;
		}  */
       // Mod Calamity = ModLoader.GetMod("CalamityMod");

        public override void SetDefaults()
		{
			item.width = 22;
			item.height = 30;
			item.maxStack = 30;
			item.rare = 1;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 2;
			item.UseSound = SoundID.Item3;
			item.consumable = true;
            item.buffType = BuffType<Buffs.ManaSickImmune>();
            item.buffTime = 217000; //217000 for one hour
        }
       /* public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[0].overrideColor = new Color(0, 204, 102);
        } */
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Staraise Potion");
            Tooltip.SetDefault("Grants immunity to Mana Sickness"); //45m
        }

	/*	public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("ManaSickImmune"), 165000); //999999999 32000 21000 = 5min 
            return true;
		} */

		public override void AddRecipes()
		{
            if (GetInstance<ItemsBuffsConfigServer>().SP)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(126, 1);
                recipe.AddIngredient(ItemID.Moonglow, 1);
                recipe.AddIngredient(ItemID.Daybloom, 1);
                recipe.AddIngredient(ItemID.Deathweed, 1);
                recipe.AddIngredient(75, 5); 
                recipe.AddTile(13); //Placed bottle now requre alchemy station balance change, reverted back due to nerfs how it was before
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
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
