using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Books
{
    public class VortexBook : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nerfs Book, Ammo & ranged weapons");
            Tooltip.SetDefault("show only Bow/gun weapons nerfs which are removed\n" +
             "Phantasm, Chlorophyte Bulllet,Celebration\n" +
             "Phoenix Blastert, D. stormbow\n" +
             "Star Canon, Clockwork Assault Rifle \n" +
             "Vortex Beater, Bee's Knees \n");
            //Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(30, 8));
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999; 
            item.value = 0;
            item.rare = 0;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips[0].overrideColor = new Color(105, 252, 182);
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