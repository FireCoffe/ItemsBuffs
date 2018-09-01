using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class DemonScythe : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.DemonScythe)
			{
                item.mana = 10;
			}
		}
	}
}
