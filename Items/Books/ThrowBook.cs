using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Books
{
    public class ThrowBook : ModItem //TO DO: remove in 1.4 or keep it as joke
    {
        public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BookCraft;
		}
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nerfs Book, of not throwing weapons");
            Tooltip.SetDefault("show only throwing class nerfs which are removed\n" +
             "Molotow Cocktail, Bone, Bone Javelin\n" +
             "Poisoned Knife\n");
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
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}