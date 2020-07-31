using Terraria;
using Terraria.ModLoader;

namespace ItemsBuffs.Buffs
{
	public class AutoRemoveDebuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Mana sickness is removed"); 
            Description.SetDefault("");
			Main.buffNoTimeDisplay[Type] = true;
        }

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[94] = true; //mana sickness
		
			   //         Player.manaSickTime = 0;
		}
	}
}
