using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class Mushroom : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == 5 &  GetInstance<ItemsBuffsConfigServer>().Mushroom)
			{
				item.potion = false;
			}
		}
	}
}
