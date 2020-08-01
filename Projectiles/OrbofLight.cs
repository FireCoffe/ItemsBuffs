using System;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;
using Terraria.DataStructures;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Projectiles
{
	public class OrbofLight : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("orb of light");
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
            ProjectileID.Sets.TrailingMode[projectile.type] = 2;
            ProjectileID.Sets.LightPet[projectile.type] = true;
        }
        public override Color? GetAlpha(Color lightColor)
        {
        return Color.Yellow * 1.0f; //return Color.White * 0.5f;
        }
        public override void SetDefaults()
		{
	        if (GetInstance<ItemsBuffsConfigServer>().OrbofLightAI == true)
            {
	        projectile.CloneDefaults(13); //18
            }
            if (GetInstance<ItemsBuffsConfigServer>().OrbofLightAI == false)
            {
	         projectile.CloneDefaults(18); //13
            }
            projectile.width = 32; //36 //48
            projectile.height = 32;  //28  //41
          //  projectile.position.Y -= 15;  //15
		//	aiType = 11;
	


		
			
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];

			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner]; //
			ItemsBuffsPlayer modPlayer = player.GetModPlayer<ItemsBuffsPlayer>();
			if (player.dead)
			{
				modPlayer.OrbofLight = false;
			}
			if (modPlayer.OrbofLight)
			{
				projectile.timeLeft = 2;
			} 
Lighting.AddLight(projectile.Center, 1f, 0.45f, 0f);  //.AddLight(projectile.Center, 1f, 0.45f, 0f); , .AddLight(projectile.Center, 1f, 1f, 0f);
		
       //     Lighting.AddLight(projectile.Center, 1f, 0.9f, 0.5f);  //Lighting.AddLight(projectile.Center, 1f, 1f, 0f)

        }
	}
}