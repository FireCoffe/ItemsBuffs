using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class GoldenShower : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().GoldenShower;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.GoldenShower)
			{
                item.shoot = mod.ProjectileType("GoldenShowerModded");
                item.damage = 28;
            }
		}
	}
}
