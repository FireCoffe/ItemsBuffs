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

namespace ItemsBuffs
{
	class ItemsBuffs : Mod
	{
        public static string ConfigFileRelativePath
        {
            get { return "Mod Configs/Removed Nerfs of items v4.5.json"; }
        }
        public static void ReloadConfigFromFile()
        {
            // Define implementation to reload your mod's config data from file
        }
        public ItemsBuffs()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
        public override void Load()
        {
            Config.Load();
        }

        public override void AddRecipes()
        {
            ModRecipe recipe;
            if (Config.NonChaosRods == true)
            {
                // ModRecipe recipe = new ModRecipe(this);
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "RodofDiscord");
                recipe.SetResult(ItemID.RodofDiscord, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "RodofDiscordClassic");
                recipe.SetResult(ItemID.RodofDiscord, 1);
                recipe.AddRecipe();

            }

            if (Config.OrbOfLight == true)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "OrbofLightItem");
                recipe.SetResult(115, 1);
                recipe.AddRecipe();

            }


            if (Config.BookNerfsCrafting == true)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "VortexBook");
                recipe.SetResult(ModContent.ItemType<Items.Books.BookOfNerfsMain>());
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "NebulaBook");
                recipe.SetResult(ModContent.ItemType<Items.Books.BookOfNerfsMain>());
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "SolarBook");
                recipe.SetResult(ModContent.ItemType<Items.Books.BookOfNerfsMain>());
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "StardustBook");
                recipe.SetResult(ModContent.ItemType<Items.Books.BookOfNerfsMain>());
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "ThrowBook");
                recipe.SetResult(ModContent.ItemType<Items.Books.BookOfNerfsMain>()); //ModContent.ItemType<Items.Books.BookOfNerfsMain>
                recipe.AddRecipe();
            }
            if (Config.PickaxeAxeCrafting == true)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(1225, 18); //hallow bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(990, 1); //pick axe
                recipe.AddRecipe();
            }
            if (Config.TitaniumCrafting == true)
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

            if (Config.OldOrbHeartBossSpawnMechanic == true)
            {
                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "DemocrimtaneBar", 3);
                recipe.AddTile(null, "CorruptForgeTile");
                recipe.SetResult(ItemID.WormFood, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "DemocrimtaneBar", 3);
                recipe.AddTile(null, "CrimsonForgeTile");
                recipe.SetResult(ItemID.WormFood, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "DemocrimtaneBar", 3);
                recipe.AddTile(null, "CorruptForgeTile");
                recipe.SetResult(ItemID.BloodySpine, 1);
                recipe.AddRecipe();

                recipe = new ModRecipe(this);
                recipe.AddIngredient(null, "DemocrimtaneBar", 3);
                recipe.AddTile(null, "CrimsonForgeTile");
                recipe.SetResult(ItemID.BloodySpine, 1);
                recipe.AddRecipe();
            }

            /*    recipe = new ModRecipe(this);
                recipe.AddIngredient(1198, 12); //TITANIUM bars
                recipe.AddTile(134); //hardmode anvil
                recipe.SetResult(1216, 1); //TITANUM head two
                recipe.AddRecipe(); */
            if (Config.RestorationPotion == true)
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
