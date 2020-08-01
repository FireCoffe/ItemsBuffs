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


namespace ItemsBuffs.Items.Tools
{
    public class OrbofLightItem : ModItem
    {
     
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orb of Light");

            if (GetInstance<ItemsBuffsConfigServer>().OrbofLightAI == true)
            {
            Tooltip.SetDefault("Summons a Light orb on chain");
            }

            if (GetInstance<ItemsBuffsConfigServer>().OrbofLightAI == false)
            {
            Tooltip.SetDefault("Summons a Light orb");
            } 
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(603);
            item.shoot = mod.ProjectileType("OrbofLight");
            item.buffType = mod.BuffType("OrbofLightBuff");
            item.rare = 8;
        }
        public override void AddRecipes()
        {
            {
            if (GetInstance<ItemsBuffsConfigServer>().OrbofLightItem == true)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(115);
                recipe.SetResult(this);
                recipe.AddRecipe();

            }


            }
        }
        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }
}