using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class PoisonedKnife : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.PoisonedKnife)
			{
				item.damage = 15;
			}
		}
	}
}
