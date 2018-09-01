using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Books
{
    public class ThrowBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book of nerfs vol.thrown");
            Tooltip.SetDefault("THIS BOOK SHOW ALL Thrown Weapons NERFS THAT MOD REMOVED\n" +
             "Molotow Cocktail, Bone\n" +
             "Poisoned Knife\n" +
            "IF ANY NERF WILL BE FOUND, IT WILL BE ADDED HERE\n");
            //Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(30, 8));
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999; 
            item.value = 0;
            item.rare = 3;
        }
        // public override void ModifyTooltips(List<TooltipLine> tooltips)
        //  {
        //      tooltips[0].overrideColor = new Color(180, 155, 100);
        //  }
        /*public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            int num = Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("AllNerfsList"), 1, false, 0, false, false);
            Main.item[num].Prefix((int)item.prefix);
            Main.item[num].newAndShiny = false;
        }*/
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