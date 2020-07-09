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
using static Terraria.ModLoader.ModContent;


namespace ItemsBuffs
{
	class ItemsBuffs : Mod
	{
        public ItemsBuffs()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
            //    AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        /*   public override void Load()
           {
               Config.Load();
           } */
        public override void Unload() //added unload idk if this works or not
        {
            base.Unload();
         // instance = null;
        //  ConfigServer = null;
        } 
        public override void AddRecipes()
        {
            ModRecipe recipe;
            if (GetInstance<ItemsBuffsConfigServer>().RMeme == true)
            {
                // ModRecipe recipe = new ModRecipe(this);
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "RodofDiscord");
                recipe.SetResult(ItemID.RodofDiscord, 1);
                recipe.AddRecipe();
                } 
            if (GetInstance<ItemsBuffsConfigServer>().RVanilla == true)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "RodofDiscordClassic");
                recipe.SetResult(ItemID.RodofDiscord, 1);
                recipe.AddRecipe();

            } 

            if (GetInstance<ItemsBuffsConfigServer>().OrbofLightItem == false)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "OrbofLightItem");
                recipe.SetResult(115, 1);
                recipe.AddRecipe();

            } 


            if (GetInstance<ItemsBuffsConfigServer>().PickaxeAxeCrafting == false)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(1225, 18); //hallow bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(990, 1); //pick axe
                recipe.AddRecipe();
            }
            if (GetInstance<ItemsBuffsConfigServer>().TitaniumCraft == false)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(1198, 18); //TITANIUM bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(1219, 1); //TITANUM LEGS
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(1198, 24); //TITANIUM bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(1218, 1); //TITANUM Brest
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(1198, 12); //TITANIUM bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(1217, 1); //TITANUM head one
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(1198, 12); //TITANIUM bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(1216, 1); //TITANUM head two
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(1198, 12); //TITANIUM bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(1215, 1); //TITANUM head three
                recipe.AddRecipe();
            }
            if (GetInstance<ItemsBuffsConfigServer>().AmazonCraft == false)
            {
            recipe = new ModRecipe(this);
            recipe.AddIngredient(620, 8);
            recipe.AddIngredient(331, 3);
            recipe.AddIngredient(209, 2);
            recipe.SetResult(3281, 1);
            recipe.AddRecipe();

            }
            if (GetInstance<ItemsBuffsConfigServer>().MolotovCocktailCraft == false)
            {
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Ale, 10);
            recipe.AddIngredient(ItemID.Silk, 1);
            recipe.AddIngredient(ItemID.Torch, 1);
            recipe.SetResult(ItemID.MolotovCocktail, 1);
            recipe.AddRecipe();

            }

            /*    recipe = new ModRecipe(this);
                recipe.AddIngredient(1198, 12); //TITANIUM bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(1216, 1); //TITANUM head two
                recipe.AddRecipe(); */
            if (GetInstance<ItemsBuffsConfigServer>().ResPotCraft == false)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(189, 1); //mana
                recipe.AddIngredient(188, 1); // heal
                recipe.AddTile(13); //bottle
                recipe.SetResult(227, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(189, 1); //mana
                recipe.AddIngredient(188, 1); // heal
                recipe.AddTile(355); //table
                recipe.SetResult(227, 1);
                recipe.AddRecipe();
            }
        }
    }
}
