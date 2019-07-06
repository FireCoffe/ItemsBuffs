using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;


namespace ItemsBuffs.Items.Tools
{
    public class OrbofLightItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orb of Light");
            Tooltip.SetDefault("Summons a light orb");
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
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(115);
            recipe.SetResult(this);
            recipe.AddRecipe();
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