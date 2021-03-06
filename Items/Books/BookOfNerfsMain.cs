using Terraria;
using Terraria.ID;
using System.Linq;
using System.Collections.Generic;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.Localization;
using ItemsBuffs.Items;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using System;
using ItemsBuffs;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Books
{
    public class BookOfNerfsMain : ModItem 
    {
       
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
       "Total nerfs removed: 67, Note: it shows also 1.4 nerfs that will be removed\n");
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

     /*   public override bool CloneNewInstances
        {
            get
            {
                return true;
            }
        }
         public override void ModifyTooltips(List<TooltipLine> tooltips)
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
            if (GetInstance<ItemsBuffsConfigServer>().BookCraft == true)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Wood, 3);
                recipe.AddTile(TileID.WorkBenches);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
       
        }
    }
}