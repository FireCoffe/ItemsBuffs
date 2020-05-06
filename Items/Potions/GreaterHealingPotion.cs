using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class GreaterHealingPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.GreaterHealingPotion &  Config.NoCooldownForHealItems)
			{
				item.potion = false;
			}
		}
	}
}
