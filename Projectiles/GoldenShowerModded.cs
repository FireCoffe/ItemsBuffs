using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Projectiles
{
	public class GoldenShowerModded : ModProjectile
	{
        public override string Texture
        {
            get
            {
                return "Terraria/Projectile_280";
            }
        }
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Shower");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(280);
			aiType = 280;
            projectile.penetrate = -1; //-5
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Ichor, 100 * 600);
        }
    }
}