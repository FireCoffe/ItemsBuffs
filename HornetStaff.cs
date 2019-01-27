using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class HornetStaff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.HornetStaff & Config.HornetStaff)
			{
                item.mana = 0;
			}
		}
	}
}
