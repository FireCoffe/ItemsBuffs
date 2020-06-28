using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class NorthPole : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().NorthPole;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 1947)
			{
				item.damage = 75;
			}
		}
	}
}
