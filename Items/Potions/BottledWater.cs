using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class BottledWater : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BottledWater &  Config.NoCooldownForHealItems)
			{
				item.potion = false;
			}
		}
	}
}
