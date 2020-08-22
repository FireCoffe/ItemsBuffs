using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class ValkyrieYoyo : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().ValkyrieYoyo == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ValkyrieYoyo)

            {
				item.knockBack = 8.5f;
                item.damage = 180;
			}
		}
	}
}
