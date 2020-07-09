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
    public class ChaosAuraPotion : ModItem
	{
      /*  public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().CAP;
		}  */
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
            item.buffType = BuffType<Buffs.ChaosStateImmune>();
            item.buffTime = 217000; //5000 for one hour
        }
       /* public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[0].overrideColor = new Color(128, 128, 128);
        } */
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chaos Aura Potion");
            Tooltip.SetDefault("Grants immunity to chaos State"); //45 mim
        }

	/*	public override bool UseItem(Player player)
		{
			player.AddBuff(mod.BuffType("ChaosStateImmune"), 165000); //999999999 32000 
            return true;
		} */

		public override void AddRecipes()
		{
            if (GetInstance<ItemsBuffsConfigServer>().CAP)
            {
                ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(126, 1);
            recipe.AddIngredient(ItemID.PixieDust, 25);
            recipe.AddIngredient(ItemID.UnicornHorn, 1);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            recipe.AddIngredient(75, 1);
            recipe.AddTile(355); //Placed Alchemy table
            recipe.SetResult(this);
            recipe.AddRecipe();
            }
        }
	}
}
