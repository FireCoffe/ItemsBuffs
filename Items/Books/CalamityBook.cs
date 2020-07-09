using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Books
{
    public class CalamityBook : ModItem
    {
        public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BookCraft;
		}
      ///  Mod Calamity = ModLoader.GetMod("CalamityMod");
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nerfs Book, Calamity mod");
            Tooltip.SetDefault("show only Calamity nerfs which are removed\n" +
             "Worm scarf, Meteorite armor set bonus\n" +
            "[c/B81515:Calamity mod]\n");
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
        //    if (Calamity != null) //            if (Config.DisableBookNerfsCrafting == true)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();

        
            }
        }
    }
}