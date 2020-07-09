using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class HeatRay : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().HeatRay;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.HeatRay)
			{
                item.mana = 0;
			}
		}
	}
}
