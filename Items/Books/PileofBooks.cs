using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Books
{
	public class PileofBooks : ModItem
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Chest");
			Tooltip.SetDefault("<right> to get all Nerfs Books volumes");
		}

		public override void SetDefaults()
		{
			item.width = 42;
			item.height = 16;
			item.maxStack = 999;
			item.rare = (-12);
			item.consumable = true;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			player.QuickSpawnItem(mod.ItemType("ThrowBook"));
			player.QuickSpawnItem(mod.ItemType("VortexBook"));
			player.QuickSpawnItem(mod.ItemType("StardustBook"));
			player.QuickSpawnItem(mod.ItemType("SolarBook"));
			player.QuickSpawnItem(mod.ItemType("NebulaBook"));
			player.QuickSpawnItem(mod.ItemType("CalamityBook"));
			player.QuickSpawnItem(mod.ItemType("BookOfNerfsMain"));

		}

		public override void AddRecipes()
		{

            if (GetInstance<ItemsBuffsConfigServer>().BookCraft == true)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Wood, 3);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
		}
	}
}