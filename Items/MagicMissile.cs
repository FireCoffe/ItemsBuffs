using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class MagicMissile : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MagicMissile & Config.MagicMissile)
			{
                item.damage = 32;
			}
		}
	}
}
