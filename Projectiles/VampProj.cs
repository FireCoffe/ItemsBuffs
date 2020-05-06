using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Projectiles
{
	public class VampProj : ModProjectile //before tweak update v.1.2 this projectile heal only 4-7 heals per second , now this projectile heal 4-7 every shot 
	{
        public override string Texture
        {
            get
            {
                return "Terraria/Projectile_304"; // this is texture of vanilla projectile
               // return "Terraria/Projectile_304_Glowmask";
            }
        }
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("VampProj"); //name of projectile
		}
        public override Color? GetAlpha(Color lightColor)
        {
            //return Color.White;
            return new Color(255, 255, 255, 0) * (1f - (float)projectile.alpha / 255f); //this makes the projectile look similar to vamp knifes
        } 
        public override void SetDefaults()
		{
			projectile.CloneDefaults(304); //this clone the stats of the projectile from vanilla
			aiType = 304;
        }
        public override void OnHitNPC(NPC n, int damage, float knockback, bool crit)
        {
            Player owner = Main.player[projectile.owner];
            int healamnt = (int)(projectile.damage * .200); //200 heal 7per second 120 4 per second 150 5 per second  3 100 per second. the issue may be by the amount of healing or idk
            Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 0, 0, 305, 0, projectile.knockBack); //Creates a new Projectile , without this it wouldnt heal
            owner.statLife += healamnt; //Gives 7.5% of the damage dealt
            owner.HealEffect(healamnt, true); //Shows you have healed by that amount of health
        }
    }
}