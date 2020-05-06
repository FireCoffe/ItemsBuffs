using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class LesserHealingPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.LesserHealingPotion &  Config.NoCooldownForHealItems)
			{
				item.potion = false;
			}
		}
	}
}
