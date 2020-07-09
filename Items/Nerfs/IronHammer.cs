using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class IronHammer : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().IronHammer;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.IronHammer)
			{
				item.hammer = 45;
			}
		}
	}
}
