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

namespace ItemsBuffs.Items.Tools
{
    [AutoloadEquip(EquipType.Neck)]
    public class BetterWormScarf : ModItem
    {
        Mod Calamity = ModLoader.GetMod("CalamityMod");

        public override void SetStaticDefaults()
        {
          
                DisplayName.SetDefault("Worm Scarf");
            Tooltip.SetDefault("Reduces damage taken by 17%" +
                    "\n[c/da0000:Calamity mod]");
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
            if (Calamity != null)
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
