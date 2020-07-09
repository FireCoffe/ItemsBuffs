using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class Celebration : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Celebration;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 3546)
			{
                item.damage = 65;
				item.crit = 10;
			}
		}
	}
}
