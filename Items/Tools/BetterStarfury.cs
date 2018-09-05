using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items.Tools
{
    public class BetterStarfury : ModItem
    {
        public override string Texture
        {
            get
            {
                return "Terraria/Item_65";
            }
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starfury");
            Tooltip.SetDefault("Causes stars to rain from the moon" +
                "\n'Forged by Celestial Creatures'");
        }
        public override void SetDefaults()
        {
            item.damage = 16;
            item.magic = true;
            item.width = 34;
            item.mana = 16;
            item.height = 34;
            item.useTime = 19;
            item.useAnimation = 19;
            item.useStyle = 1; 
            item.knockBack = 5f;
            item.value = Terraria.Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item65;
            item.autoReuse = false;
            item.shoot = (9);
            item.shootSpeed = 10f;                //projectile speed         
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2);  //This defines how many projectiles to shot //6 is defalt
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }
        /* i tried to find starfury dust type but i didnt find it
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                //Emit dusts when swing the sword
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, (264));
            }
        } */
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Starfury, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "BetterStarfury");
            recipe.SetResult(ItemID.Starfury, 1);
            recipe.AddRecipe();
        }
	}
}
