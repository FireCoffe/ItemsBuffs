using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class StardustDragonStaff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.StardustDragonStaff & Config.StardustDragonStaff)
			{
				item.damage = 60;
			}
		}
	}
}
