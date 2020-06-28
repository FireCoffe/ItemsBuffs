using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Books
{
    public class NebulaBook : ModItem
    {
        public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BookCraft;
		}
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Nerfs Book, Magic Class");
            Tooltip.SetDefault("show only Magic Weapons nerfs which are removed\n" +
             "Aqua Scepter, Blizzard Staff, Book of Skulls\n" +
             "Crystal Storm, Demon Scythe, Diamond Staff, Flamelash, Flower of Fire, Frost Staff\n" +
             "Golden Shower, Heat Ray\n" +
             "Leaf Blower,Magic Missile, Medusa Head\n" +
             "Nebula Arcanum\n" +
             "Poison Staff\n" +
             "Rainbow Rod, Spectre hood, Razorpine, sky fracture\n" +
             "Shadowbeam Staff\n" +
             "Unholy Trident\n");
            //   "\n");
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

                {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
                }
            }
        }
    }
