using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class FalconBlade : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().FalconBlade;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 2608)
			{
				item.damage = 30;
				item.useTime = 15;
				item.useAnimation = 15;
			}
		}
	}
}
