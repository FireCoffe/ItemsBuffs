using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class DiamondStaff : GlobalItem
	{
	    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().DiamondStaff;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.DiamondStaff)
			{
               item.shoot = mod.ProjectileType("DiamondBolt");
			}
		}
	}
}
