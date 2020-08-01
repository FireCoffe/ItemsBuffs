using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class BottledHoney : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BottledHoney &  GetInstance<ItemsBuffsConfigServer>().BottledHoney)
			{
				item.potion = false;
			}
		}
	}
}
