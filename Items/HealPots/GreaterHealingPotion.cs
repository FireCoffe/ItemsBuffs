using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace ItemsBuffs.Items.HealPots
{
	public class GreaterHealingPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.GreaterHealingPotion &  GetInstance<ItemsBuffsConfigServer>().GreaterHealingPotion)
			{
				item.potion = false;
			}
		}
	}
}
