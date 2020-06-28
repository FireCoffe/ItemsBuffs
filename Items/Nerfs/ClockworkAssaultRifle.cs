using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class ClockworkAssaultRifle : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().ClockworkAssaultRifle;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ClockworkAssaultRifle) //434
                {
				item.damage = 19;
			}
		}
	}
}
