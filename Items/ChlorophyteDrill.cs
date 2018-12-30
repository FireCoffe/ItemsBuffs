using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class ChlorophyteDrill : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ChlorophyteDrill & Config.ChlorophyteDrill)
			{
				item.pick = 210;
			}
		}
	}
}
