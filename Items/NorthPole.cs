using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class NorthPole : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == 1947)
			{
				item.damage = 75;
			}
		}
	}
}
