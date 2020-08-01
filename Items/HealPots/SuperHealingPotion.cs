using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class SuperHealingPotion : GlobalItem
	{
		
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.SuperHealingPotion &  GetInstance<ItemsBuffsConfigServer>().SuperHealingPotion)
			{
				item.potion = false;

			//	item.potionDelay = 0; //3600
			}
		}
	}
}
