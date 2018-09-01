using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Projectiles
{
	public class DiamondBolt : ModProjectile
	{
        public override string Texture
        {
            get
            {
                return "Terraria/Projectile_126";
            }
        }
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DiamondBolt");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(126);
			aiType = 126;
            projectile.penetrate = 4;
        }
    }
}