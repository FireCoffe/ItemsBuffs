using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using Terraria.DataStructures;
using Terraria.Localization;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.CalamityNerfs
{
    [AutoloadEquip(EquipType.Neck)]
    public class BetterWormScarf : ModItem
    {


        public override void SetStaticDefaults()
        {
          
                DisplayName.SetDefault("Wormy Scarf");
            Tooltip.SetDefault("Reduces damage taken by 17%" +
                    "\n[c/B81515:Calamity mod]"); //B81515   da0000 color codes
          //  "\n''");
        }
        public override void SetDefaults()
        {
            item.expert = true;
            item.width = 26;
           	item.accessory = true;
            item.height = 26;
            item.rare = (-11);

        }

        //  public override void UpdateEquip(Player player)
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.endurance = 0.17f; //17% percent damage reduction

        }
        public override void AddRecipes()
        {
          	 if (GetInstance<ItemsBuffsConfigServer>().WS == true)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(3224, 1);
                recipe.SetResult(this);
                recipe.AddRecipe();

                recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "BetterWormScarf");
                recipe.SetResult(3224, 1);
                recipe.AddRecipe();
            }
    
        }
	}
}
