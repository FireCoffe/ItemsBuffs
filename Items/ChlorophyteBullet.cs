using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class ChlorophyteBullet : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ChlorophyteBullet)
			{
				item.damage = 15;
			}
		}
	}
}
