using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class FrostStaff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.FrostStaff)
			{
                item.damage = 53;
                item.mana = 10;
			}
		}
	}
}
