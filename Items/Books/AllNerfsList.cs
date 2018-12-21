using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Books
{
    public class AllNerfsList : ModItem //all of these book are based on lunar event expect for book of nerfs thrown
    {
       // public int Frame;
        //public int FrameCounter;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book of nerfs");
            Tooltip.SetDefault("THIS BOOK SHOW ALL NERFS THAT MOD REMOVED\n" +
             "Aqua Scepter, Bananarang, Blizzard Staff, Blue Moon, Bone, Book of Skulls\n" +
             "Copper Shortsword, Crystal Storm, Cuttlass, Demon Scythe, Diamond Staff, Flamarang, Flamelash, Flower of Fire, Frost Staff\n" +
             "Golden Shower, Heat Ray, Hornet Staff, Chlorophyte Bulllet, Imp Staff, Iron Hammer\n" +
             "Leaf Blower,Magic Missile, Medusa Head, Molotow Cocktail\n" +
             "Molten Pickaxe, Muramasa, Nebula Arcanum, Nightmare Pickaxe, North Pole, Phantasm\n" +
             "Phoenix Blaster, Poisoned Knife,Pickaxe Axe, Poison Staff, Possessed Hatchet\n" +
             "Rainbow Rod, Rod of Discord, Razorpine, Reds Throw\n" +
             "Shadowbeam Staff, Slime Staff, Spectre Hood, Staff of Regrowth, Star Canon, Stardust Dragon staff, Sunfury\n" +
             "StarFury, Unholy Trident, Valkyrie Yoyo, Vampire Knifes, Vilethorn, Vortex Beater\n" +
            "IF ANY NERF WILL BE FOUND, IT WILL BE ADDED HERE\n");
            //Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(30, 8));
        }
        //this was cancelled too
        /*  public override bool CanRightClick()
          {
              return true;
          }
          public override void RightClick(Player player)
          {
              int num = Item.NewItem((int)player.position.X, (int)player.position.Y, player.width, player.height, mod.ItemType("NebulaBook"), 1, false, 0, false, false);
              Main.item[num].Prefix((int)item.prefix);
              Main.item[num].newAndShiny = false;
          }*/

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 30;
            item.maxStack = 999; 
            item.value = 0;
            item.rare = (-12);
        }

        public override bool CloneNewInstances
        {
            get
            {
                return true;
            }
        }
        //this was used for new sprite of book of nerfs but it was cancelled , the sprite is in mod icon of mod
       /* public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            foreach (TooltipLine line5 in tooltips) 
            {
                if (line5.mod == "Terraria" && line5.Name == "ItemName")
                {
                    if (Frame == 0)
                    {
                        line5.text = ("[c/ff6600:Book of nerfs]");
                    }
                    if (Frame == 1)
                    {
                        line5.text = ("[c/00cc66:Book of nerfs]");
                    }
                    if (Frame == 2)
                    {
                        line5.text = ("[c/ff00ff:Book of nerfs]");
                    }
                    if (Frame == 3)
                    {
                        line5.text = ("[c/00ccff:Book of nerfs]");
                    }
                }
            }
        } 
        public override void UpdateInventory(Player player)
        {
            FrameCounter++; //increase the frameCounter by one
            if (FrameCounter >= 20) //once the frameCounter has reached 3 - change the 10 to change how fast the projectile animates
            {
                FrameCounter = 0;
                Frame++; //go to the next frame
                if (Frame > 3) //if past the last frame
                    Frame = 0; //go back to the first frame
            }
        } */
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(9, 5);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}