using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class ValkyrieYoyo : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ValkyrieYoyo)

            {
                item.damage = 180;
			}
		}
	}
}
