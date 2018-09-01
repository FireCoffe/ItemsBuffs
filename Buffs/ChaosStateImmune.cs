using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ItemsBuffs.Buffs
{
	public class ChaosStateImmune : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("[c/F7FE2E:Light Charm]");
            Description.SetDefault("chaos State dont longer affect you");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffImmune[BuffID.ChaosState] = true;
        }
    }
}
