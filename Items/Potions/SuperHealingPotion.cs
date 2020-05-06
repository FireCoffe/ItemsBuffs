using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class SuperHealingPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.SuperHealingPotion &  Config.NoCooldownForHealItems)
			{
				item.potion = false;
			}
		}
	}
}
