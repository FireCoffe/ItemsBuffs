using Terraria;
using Terraria.ModLoader;

namespace ItemsBuffs.Buffs
{
	public class ManaSickImmune : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("[c/00cc66:Mana Protection]");
            Description.SetDefault("the magic damage dont go down");
        }

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[94] = true;
		}
	}
}
