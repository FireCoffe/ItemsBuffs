using Terraria;
using Terraria.ModLoader;

namespace ItemsBuffs.Buffs
{
	public class ManaSickImmune : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("[c/FFC400:Fallen Star] blessing"); //[c/00cc66:Magic Protection]
            Description.SetDefault("immunity to Mana Sickness");
        }

		public override void Update(Player player, ref int buffIndex)
		{
			
			player.buffImmune[94] = true; //mana sickness
				
		}
	}
}
