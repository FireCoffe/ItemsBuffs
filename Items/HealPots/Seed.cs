using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class Seed : GlobalItem //
	{
		public override void SetDefaults(Item item)
		{
			if (GetInstance<ItemsBuffsConfigServer>().GHP)
                {
				item.potion = false;
			}
		}
	}
}
