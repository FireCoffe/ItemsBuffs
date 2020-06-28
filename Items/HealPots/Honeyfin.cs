using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class Honeyfin : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Honeyfin &  GetInstance<ItemsBuffsConfigServer>().Honeyfin)
			{
				item.potion = false;
			}
		}
	}
}
