using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class HealingPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.HealingPotion &  Config.NoCooldownForHealItems)
			{
				item.potion = false;
			}
		}
	}
}
