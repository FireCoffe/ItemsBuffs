using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Books
{
    public class CalamityBook : ModItem
    {
        Mod Calamity = ModLoader.GetMod("CalamityMod");
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book of nerfs, volume of Calamity mod");
            Tooltip.SetDefault("show only Calamity nerfs which are removed\n" +
             "Worm scarf\n" +
            "[c/da0000:Calamity mod]\n");
           // Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(30, 2)); //30 the speed of frame , 2 is how much frames the image have
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999; 
            item.value = 0;
            item.rare = 10;
        }

        public override void AddRecipes()
        {
            if (Calamity != null & Config.BookNerfsCrafting == true) //            if (Config.DisableBookNerfsCrafting == true)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "BookOfNerfsMain");
                recipe.AddTile(18);
                recipe.SetResult(this);
                recipe.AddRecipe();

        
            }
        }
    }
}