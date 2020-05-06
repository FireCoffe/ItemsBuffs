using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;


namespace ItemsBuffs.Items.Tools
{
	public class DemocrimtaneOre : ModItem
	{
     //   int stack;
        public override void SetStaticDefaults()
		{
			if (Config.OldOrbHeartBossSpawnMechanic == true)

				DisplayName.SetDefault("Democrimtane ore");
            Tooltip.SetDefault("'The dark energy pulse within ore'");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(14, 17));
      //      ItemID.Sets.AnimatesAsSoul[item.type] = true;
        //  ItemID.Sets.ItemIconPulse[item.type] = true;
            //  Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(30, 2));
        }


     /*   public override bool PreDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale) //THIS CODE IS FROM VAMPIRE KNIFES MOD ALL RIGHTS BELONG TO THE AUTHOR OF THE VAMPIRE KNIFES EXPANDED
        {
            if (stack == 5)
            {
                return true;
            }
            if (stack == 10)
            {
             //   Texture2D texture = mod.GetTexture("Items/Tools/HeartofLife1");
               // spriteBatch.Draw(texture, position, null, Color.White, 0, origin, scale, SpriteEffects.None, 0f);
                return true;
            }
            if (stack >= 15)
            {
                Item.NewItem(Main.LocalPlayer.getRect(), mod.ItemType("Bar"));

                return false;
            }
            else
                return true;
        }
        public override void UpdateInventory(Player player)
        {
            stack = item.stack;
            if (item.stack == 15)
            {
                item.SetDefaults(mod.ItemType("Bar"));
            }
            base.UpdateInventory(player);
        } */
        public override void SetDefaults()
		{
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
			item.value = 0;
			item.rare = 1;
		}

		public override void AddRecipes()
		{


			/*
			// Start a new Recipe. (Prepend with "ModRecipe " if 1st recipe in code block.)
			recipe = new ModRecipe(mod);
			// Add a Vanilla Ingredient. 
			// Look up ItemIDs: https://github.com/bluemagic123/tModLoader/wiki/Vanilla-Item-IDs
			// To specify more than one ingredient, use multiple recipe.AddIngredient() calls.
			recipe.AddIngredient(ItemID.DirtBlock);
			// An optional 2nd argument will specify a stack of the item. 
			recipe.AddIngredient(ItemID.Acorn, 10);
			// We can also specify the current item as an ingredient
			recipe.AddIngredient(this, 2);
			// Add a Mod Ingredient. Do not attempt ItemID.EquipMaterial, it's not how it works.
			recipe.AddIngredient(mod, "EquipMaterial", 3);
			// an alternate approach to the above.
			recipe.AddIngredient(mod.ItemType("EquipMaterial"), 3);
			// RecipeGroups allow you create a recipe that accepts items from a group of similar ingredients. For example, all varieties of Wood are in the vanilla "Wood" Group
			recipe.AddRecipeGroup("Wood"); // check here for other vanilla groups: https://github.com/bluemagic123/tModLoader/wiki/ModRecipe#public-void-addrecipegroupstring-name-int-stack--1
			// Here is using a mod recipe group. Check out ExampleMod.AddRecipeGroups() to see how to register a recipe group.
			recipe.AddRecipeGroup("ExampleMod:ExampleItem", 2);
			// To specify a crafting station, specify a tile. Look up TileIDs: https://github.com/bluemagic123/tModLoader/wiki/Vanilla-Tile-IDs
			recipe.AddTile(TileID.WorkBenches);
			// A mod Tile example. To specify more than one crafting station, use multiple recipe.AddTile() calls.
			recipe.AddTile(mod, "ExampleWorkbench");
			// There is a limit of 14 ingredients and 14 tiles to a recipe.
			// Special
			// Water, Honey, and Lava are not tiles, there are special bools for those. Also needSnowBiome. Water also specifies that it works with Sinks.
			recipe.needHoney = true;
			// Set the result of the recipe. You can use stack here too. Since this is in a ModItem class, we can use "this" to specify this item as the result.
			recipe.SetResult(this, 999); // or, for a vanilla result, recipe.SetResult(ItemID.Muramasa);
			// Finish your recipe
			recipe.AddRecipe();
			*/
		}
	}
}
