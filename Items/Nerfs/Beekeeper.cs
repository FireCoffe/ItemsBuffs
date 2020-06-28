using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Beekeeper : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Beekeeper;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 1123)
			{
				item.damage = 26;
			    item.useTime = 22;
				item.knockBack = 5.3f;
				item.autoReuse = true;
				item.useAnimation = 22;
			}
		}
	}
}
