using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class FakeGrayFoxCowl : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Mystery cowl");
            Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
            item.width = 32; //18
			item.height = 32; //18
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 1;
			item.vanity = true; //item.defense = 999999;
        }

        public override void AddRecipes()
		{
            var recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 7);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}