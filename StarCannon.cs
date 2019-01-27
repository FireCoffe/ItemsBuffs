using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class StarCannon : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.StarCannon & Config.StarCannon)
			{
                item.damage = 75;
			}
		}
	}
}
