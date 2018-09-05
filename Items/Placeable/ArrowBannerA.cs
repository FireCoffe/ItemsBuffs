using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Placeable {
    public class ArrowBannerA : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Luminite Arrow Banner");
            Tooltip.SetDefault(
               // "Nearby players get a bonus against:\n" + 
               // "Storm Diver, Vortexian, Alien Queen, Alien Hornet, Alien Larva\n" +
                "still waiting until arrow will hit a ground");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.rare = 9;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("ArrowBanner");
            item.placeStyle = 0;
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            // recipe.AddIngredient(ItemID.VortexHornetBanner);
             recipe.AddIngredient(ItemID.Silk, 3);
            //recipe.AddIngredient(ItemID.VortexHornetQueenBanner);
            //recipe.AddIngredient(ItemID.VortexLarvaBanner);
            //recipe.AddIngredient(ItemID.VortexRiflemanBanner);
            //recipe.AddIngredient(ItemID.VortexSoldierBanner);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
