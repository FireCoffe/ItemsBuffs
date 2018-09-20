using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Sunfury : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Sunfury & Config.Sunfury)
			{
				item.damage = 40;
			}
		}
	}
}
