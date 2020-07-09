using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//using Terraria.ItemsBuffsConfig;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Books
{
    public class BookOfNerfsMain : ModItem //v3.4: removed old sprite of  it , and replaced with fused version of all books , all of these book are based on lunar event but not book of nerfs thrown
    {
        public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BookCraft;
		}
    /*    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BookCraft;
		} */
       // public int Frame;
     //   public int FrameCounter;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Celestial Nerfs Book");
            Tooltip.SetDefault("show only all nerfs which are removed\n" +
             "Aqua Scepter, Bananarang, Blizzard Staff, Blue Moon, Bone, Book of Skulls\n" +
             "Copper Shortsword, Crystal Storm, Cuttlass, Demon Scythe, Diamond Staff, Flamarang, Flamelash, Flower of Fire, Frost Staff\n" +
             "Golden Shower, Heat Ray, Hornet Staff, Chlorophyte Bulllet, Chlorophyte Drill, Imp Staff, Iron Hammer\n" +
             "Leaf Blower,Magic Missile, Medusa Head, Molotow Cocktail, Titanium armor craft nerf, Restoration potion\n" +
             "Molten Pickaxe, Muramasa, Nebula Arcanum, Nightmare Pickaxe, North Pole, Phantasm\n" +
             "Phoenix Blaster, Poisoned Knife,Pickaxe Axe, Poison Staff, Possessed Hatchet\n" +
             "Rainbow Rod, Rod of Discord, Razorpine, Reds Throw\n" +
             "Shadowbeam Staff, ShadowOrb, Slime Staff, Spectre Hood, Staff of Regrowth, Star Cannon, Stardust Dragon staff, Sunfury \n" +
             "StarFury, Unholy Trident, Valkyrie Yoyo, Vampire Knifes, Vilethorn, Vortex Beater\n" +
             "this book doesnt have all nerfs in it there too much nerfs\n" +
       //     "IF ANY NERF WILL BE FOUND, IT WILL BE ADDED HERE\n");
       "Total nerfs removed: 67\n");
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
     //   public override void ModifyTooltips(List<TooltipLine> tooltips)
       // {
         //   tooltips[2].overrideColor = new Color(10, 153, 255);
        //}
        public override void SetDefaults()
        {

            item.width = 40;
            item.height = 40;
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
        //this was used for new sprite of book of nerfs but it was cancelled and again cancelled
      /*   public override void ModifyTooltips(List<TooltipLine> tooltips)
         {

            foreach (TooltipLine line5 in tooltips) 
             {
                 if (line5.mod == "Terraria" && line5.Name == "ItemName")
                 {
                     if (Frame == 0)
                     {
                         line5.text = ("[c/d325e7:Book of nerfs]");
                     }
                     if (Frame == 1)
                     {
                         line5.text = ("[c/fe9e23:Book of nerfs]");
                     }
                     if (Frame == 2)
                     {
                         line5.text = ("[c/009aff:Book of nerfs]");
                     }
                     if (Frame == 3)
                     {
                         line5.text = ("[c/2ff79f:Book of nerfs]");
                     }
                     if (Frame == 4)
                     {
                         line5.text = ("[c/2ff79f:Book of nerfs]");
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
                 if (Frame > 4) //if past the last frame
                     Frame = 0; //go back to the first frame
             }
         } */
        public override void AddRecipes()
        {
           // if (ItemsBuffsConfigServer.BookCraft == true)
           

            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
       
        }
    }
}