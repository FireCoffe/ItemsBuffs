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
        public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BookCraft;
		}
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
        /*
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            int num = Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("ThrowBook"), 1, false, 0, false, false);
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