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
			DisplayName.SetDefault("parallel dimensions"); //[c/808080:parallel dimensions]
            Description.SetDefault(
            "immunity to chaos State");
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffImmune[BuffID.ChaosState] = true; //buff name
        }
    }
}
