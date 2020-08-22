using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Sunfury : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Sunfury == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Sunfury)
			{
				item.damage = 40;
			}
		}
	}
}
