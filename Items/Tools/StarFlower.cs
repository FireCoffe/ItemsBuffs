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
   /// [AutoloadEquip(EquipType.Neck)]
    public class StarFlower : ModItem
    {
       

        public override void SetStaticDefaults()
        {
          
                DisplayName.SetDefault("Star Flower");
            Tooltip.SetDefault("8% reduced mana usage\n" +
                "Automatically uses Mana Potions when needed\n" +
                "Grants immunity to mana sickness\n");

          //  "\n''");
        }
        public override void SetDefaults()
        {
            item.width = 20;
           	item.accessory = true;
            item.height = 50;
            item.rare = ItemRarityID.Yellow;
           

        }

        //  public override void UpdateEquip(Player player)
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
        player.buffImmune[94] = true;
		player.manaFlower = true;
		player.manaCost -= 0.08f;
            //player.shadowDodge = true;
//player.shadowDodgeCount = 3;
          ///  player.shadowDodgeTimer = 999999;
           
            
     //    player.manaMagnet = true;
		///	player.magicCuffs = true;
        ///	
        }
        public override void AddRecipes()
        {
      //      if () //
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.ManaFlower);
                recipe.AddIngredient(null, "StaraisePotion");
                recipe.AddIngredient(ItemID.HoneyBlock, 5);
                recipe.AddIngredient(ItemID.Hive, 3);
                recipe.AddIngredient(ItemID.FallenStar, 1);
                recipe.SetResult(this);
                recipe.AddRecipe();

            }
    
        }
	}
}
