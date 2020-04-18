using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Books
{
    public class SolarBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book of nerfs, volume of swords");
            Tooltip.SetDefault("show only Melee weapons nerfs which are removed\n" +
             "Bananarang, Blue moon\n" +
             "Copper Shortsword, Cuttlass, Flamarang\n" +
             "Iron Hammer, Chlorophyte Drill\n" +
             "Molten Pickaxe, Muramasa, Nightmare Pickaxe, North Pole\n" +
             "Possessed Hatchet, Pickaxe Axe\n" +
             "Rainbow Rod, Rod of Discord, Reds Throw\n" +
             "Staff of Regrowth, Sunfury, StarFury\n" +
             "Valkyrie Yoyo, Vampire Knifes\n");
            //Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(30, 8));
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999; 
            item.value = 0;
            item.rare = (-11);
        }
       /* public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            int num = Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("StardustBook"), 1, false, 0, false, false);
            Main.item[num].Prefix((int)item.prefix);
            Main.item[num].newAndShiny = false;
        } */
        public override void AddRecipes()
        {
            if (Config.BookNerfsCrafting == true)
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