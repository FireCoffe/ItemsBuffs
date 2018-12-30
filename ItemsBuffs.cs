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
            get { return "Mod Configs/Removed Nerfs of items v3.3.json"; }
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
           ModRecipe recipe = new ModRecipe(this);
           recipe.AddIngredient(null, "RodofDiscord");
           recipe.SetResult(ItemID.RodofDiscord, 1);
           recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "VortexBook");
            recipe.SetResult(ItemType<Items.Books.AllNerfsList>());
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "NebulaBook");
            recipe.SetResult(ItemType<Items.Books.AllNerfsList>());
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "SolarBook");
            recipe.SetResult(ItemType<Items.Books.AllNerfsList>());
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "StardustBook");
            recipe.SetResult(ItemType<Items.Books.AllNerfsList>());
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "ThrowBook");
            recipe.SetResult(ItemType<Items.Books.AllNerfsList>());
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(1225, 18);
            recipe.AddTile(134);
            recipe.SetResult(990, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Bar", 1);
            recipe.SetResult(ItemID.WormFood, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Bar", 1);
            recipe.SetResult(ItemID.BloodySpine, 1);
            recipe.AddRecipe();
        }
    }
}
