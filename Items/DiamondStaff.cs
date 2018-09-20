using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class DiamondStaff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.DiamondStaff & Config.DiamondStaff)
			{
               item.shoot = mod.ProjectileType("DiamondBolt");
			}
		}
	}
}
