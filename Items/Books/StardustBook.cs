using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Books
{
    public class StardustBook : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nerfs Book, Summoner");
            Tooltip.SetDefault("show only Summon Staffs nerfs which are removed\n" +
             "Imp Staff, Hornet staff\n" +
             "Slime Staff, Stardust Dragon staff\n");

        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999; 
            item.value = 0;
            item.rare = 9;
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