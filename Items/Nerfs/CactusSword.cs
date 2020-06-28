using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class CactusSword  : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().CactusSword;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.CactusSword)
			{
		        item.useAnimation = 25;
				item.useTime = 25;
				item.knockBack = 5f;
                item.damage = 9;
			}
		}
	}
}
