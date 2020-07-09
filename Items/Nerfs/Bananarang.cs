using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Bananarang : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().AquaScepter;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Bananarang)
			{
                item.useTime = 7;
                item.useAnimation = 7;
			}
		}
	}
}
