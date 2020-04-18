using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Books
{
	public class PileofBooks : ModItem
	{


        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Book of nerfs , Collector edition");
			Tooltip.SetDefault("<right> to get all books of nerfs volumes");
		}

		public override void SetDefaults()
		{
			item.width = 42;
			item.height = 16;
            item.maxStack = 999;
            item.rare = (-12);
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
            player.QuickSpawnItem(mod.ItemType("BookOfNerfsMain"));
   
        }

		public override void AddRecipes()
		{
			if (Config.BookNerfsCrafting == true)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddTile(18);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}