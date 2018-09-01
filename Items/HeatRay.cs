using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class HeatRay : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.HeatRay)
			{
                item.mana = 0;
			}
		}
	}
}
