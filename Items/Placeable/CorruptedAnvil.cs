using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Placeable
{
	public class CorruptedAnvil : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used to extract essence of Heart of life");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 999999999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 11;
			item.value = Item.sellPrice(0, 0, 0, 0);
			item.createTile = mod.TileType("CorruptedAnvil");
		}

		public override void AddRecipes()
		{

		}
	}
}