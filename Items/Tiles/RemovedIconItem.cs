using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Tiles {
    public class RemovedIconItem : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Removed Nerfs of items Banner");
            Tooltip.SetDefault(
                "");
        }

        public override void SetDefaults() {
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.rare = 2;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("RemovedIcon");
            item.placeStyle = 0;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[0].overrideColor = new Color(204, 204, 204);
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
             recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
