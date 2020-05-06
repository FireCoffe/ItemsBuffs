using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Honeyfin : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Honeyfin &  Config.NoCooldownForHealItems)
			{
				item.potion = false;
			}
		}
	}
}
