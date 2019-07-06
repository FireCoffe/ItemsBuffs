using Terraria;
using Terraria.ModLoader;

namespace ItemsBuffs.Buffs
{
    public class OrbofLightBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Orb of Light");
            Description.SetDefault("light your way");
            Main.buffNoTimeDisplay[Type] = true;
            Main.lightPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<ItemsBuffsPlayer>(mod).OrbofLight = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("OrbofLight")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 3), player.position.Y + (float)(player.height / 3), 0f, 0f, mod.ProjectileType("OrbofLight"), 0, 0f, player.whoAmI, 0f, 0f);
            }

        }
    }
}