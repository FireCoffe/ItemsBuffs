using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class GoldenShower : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.GoldenShower)
			{
                item.shoot = mod.ProjectileType("GoldenShower");
                item.damage = 28;
            }
		}
	}
}
