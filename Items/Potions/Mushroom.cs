using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Mushroom : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == 5 &  Config.NoCooldownForHealItems)
			{
				item.potion = false;
			}
		}
	}
}
