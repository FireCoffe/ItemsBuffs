using Terraria;
using Terraria.ID;
using System.Linq;
using System.Collections.Generic;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.Localization;
using ItemsBuffs.Items.Tiles;
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
		public ItemsBuffs()
		{
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
            // recipe = new ModRecipe(this);
            // recipe.AddIngredient(ItemID.BlueBerries, 20);
            // recipe.AddTile(TileID.WorkBenches);
            // recipe.SetResult(ItemID.PumpkinPie, 2);
            // recipe.AddRecipe();
        }
    }
}
