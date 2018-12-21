using System;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;
using Terraria.DataStructures;

namespace ItemsBuffs.Items.Tools
{
    public class RodofDiscord : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rod of Discord"); 
            Tooltip.SetDefault("on use it doesnt give chaos state");
            Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.useTime = 18;
            item.useAnimation = 18;
            item.UseSound = SoundID.Item8;
            item.useStyle = 1;
            item.value = Terraria.Item.sellPrice(0, 10, 0, 0);
            item.rare = 9;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RodofDiscord, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        // Code is modified from the vanilla source code handling Rod of Discord
        public override bool UseItem(Player player)
        {
          //  const int COST_MANA = 50;
            const int MAX_DIST_X = 999999;
            const int MAX_DIST_Y = 999999;
           // const int TIME_DEBUFF_HURT = 120;
         //   const int TIME_DEBUFF_CHAOS = 600;

            // Can't teleport at all in chaos state
           // if (player.chaosState)
          //  {
          //      Main.PlaySound(SoundID.Item16, player.position);
          //      return true;
          //  }

            // Splash sound effect if you don't have enough mana
         //   if (player.statMana < COST_MANA)
         //   {
         //       Main.PlaySound(SoundID.Splash, player.position);
        //        return true;
        //    }

         //   if (!player.CheckMana(COST_MANA, false, true))
         //   {
        //        Main.PlaySound(SoundID.Item16, player.position);
        //        return true;
        //    }

            // Get teleport location
            Vector2 teleportTo;
            teleportTo.X = (Main.mouseX + Main.screenPosition.X);

            teleportTo.Y = (float)((double)player.gravDir != 1.0 ? (Main.screenPosition.Y + (double)Main.screenHeight - (double)Main.mouseY) : ((double)Main.mouseY + Main.screenPosition.Y - (double)player.height));

            // Can't teleport beyond a certain distance, specified by MAX_DIST_X and MAX_DIST_Y
            int distX = (int)(System.Math.Abs(teleportTo.X - player.position.X)) / 16;
            int distY = (int)(System.Math.Abs(teleportTo.Y - player.position.Y)) / 16;

            if (distX > MAX_DIST_X || distY > MAX_DIST_Y)
            {
                Main.PlaySound(SoundID.Item8, player.position);
                return true;
            }

            // Must be in bounds
            if (teleportTo.X > 50.0 && teleportTo.X < (double)(Main.maxTilesX * 16 - 50) && (teleportTo.Y > 50.0 && teleportTo.Y < (double)(Main.maxTilesY * 16 - 50)))
            {
                // Get tile array indexes
                int index1 = (int)(teleportTo.X / 16.0);
                int index2 = (int)(teleportTo.Y / 16.0);

                // Can't teleport into a solid block, or into the Lihzahrd temple early
                if (((int)Main.tile[index1, index2].wall != 87 || (double)index2 <= Main.worldSurface || NPC.downedPlantBoss) && !Collision.SolidCollision(teleportTo, player.width, player.height))
                {
                    player.Teleport(teleportTo, 1, 0);

                    // Copied from Rod of Discord source code
                    NetMessage.SendData(65, -1, -1, (NetworkText)null, 0, (float)player.whoAmI, (float)teleportTo.X, (float)teleportTo.Y, 1, 0, 0);

                    // Always decrease life by 1/7th
                    //player.statLife = player.statLife - player.statLifeMax2 / 7;

                    // If you die, you get a special message
                    if (player.statLife <= 0)
                    {
                        PlayerDeathReason damageSource = PlayerDeathReason.ByCustomReason(player.name + "Discord Chat broke your hands");
                        player.KillMe(damageSource, 1.0, 0, false);

                        return true;
                    }

                    // Decrease mana
                  //  player.CheckMana(COST_MANA, true, true);

                    // Give player chaos state
                 //   player.AddBuff(BuffID.ChaosState, TIME_DEBUFF_CHAOS, true);

                    // Give player slow and cursed inferno debuffs. The rod's broken, after all.
                 //   player.AddBuff(BuffID.Slow, TIME_DEBUFF_HURT, true);
                 //   player.AddBuff(BuffID.CursedInferno, TIME_DEBUFF_HURT, true);
                }
                else
                {
                    Main.PlaySound(SoundID.Item8, player.position);
                }
            }
            else
            {
                Main.PlaySound(SoundID.Item8, player.position);
            }

            return true;
        }
    }
}