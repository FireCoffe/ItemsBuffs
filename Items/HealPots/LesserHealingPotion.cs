using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class LesserHealingPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.LesserHealingPotion & GetInstance<ItemsBuffsConfigServer>().LesserHealingPotion)
			{
				item.potion = false;
			}
		
		}
	}
}
