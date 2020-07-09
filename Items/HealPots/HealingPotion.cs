using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace ItemsBuffs.Items.HealPots
{
	public class HealingPotion : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.HealingPotion &  GetInstance<ItemsBuffsConfigServer>().HealingPotion)
			{
				item.potion = false;
			}
		}
	}
}
