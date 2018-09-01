using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class BlueMoon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BlueMoon)
			{
				item.damage = 30;
			}
		}
	}
}
