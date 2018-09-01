using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Books
{
    public class NebulaBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book of nerfs vol.Magic");
            Tooltip.SetDefault("THIS BOOK SHOW ALL MAGIC WPNS NERFS THAT MOD REMOVED\n" +
             "Aqua Scepter, Blizzard Staff, Book of Skulls\n" +
             "Crystal Storm, Demon Scythe, Diamond Staff, Flamelash, Flower of Fire, Frost Staff\n" +
             "Golden Shower, Heat Ray\n" +
             "Leaf Blower,Magic Missile, Medusa Head\n" +
             "Nebula Arcanum\n" +
             "Poison Staff\n" +
             "Rainbow Rod, Spectre hood, Razorpine\n" +
             "Shadowbeam Staff\n" +
             "Unholy Trident\n" +
            "IF ANY NERF WILL BE FOUND, IT WILL BE ADDED HERE\n");
           // Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(30, 2)); //30 the speed of frame , 2 is how much frames the image have
        }
       /* public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            int num = Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("SolarBook"), 1, false, 0, false, false);
            Main.item[num].Prefix((int)item.prefix);
            Main.item[num].newAndShiny = false;
        }*/
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999; 
            item.value = 0;
            item.rare = 11;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "AllNerfsList");
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}