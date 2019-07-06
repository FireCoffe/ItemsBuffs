using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Placeable
{
	public class CrimsonForge : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used to extract dark energy from demonrimtane bars");
		}

		public override void SetDefaults()
		{
			item.width = 48;
			item.height = 34;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 1;
			item.value = Item.sellPrice(0, 0, 0, 0);
			item.createTile = mod.TileType("CrimsonForgeTile");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Furnace);
            recipe.AddIngredient(null, "DemocrimtaneBar", 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}