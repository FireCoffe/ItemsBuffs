using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class RedsThrow : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().RedsThrow;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 3287)

            {
                item.damage = 180;
			}
		}
	}
}
