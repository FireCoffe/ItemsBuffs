using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class TheBeesKnees : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().TheBeesKnees;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 2888)
			{
                item.damage = 26;
				item.useTime = 23;
				item.useAnimation = 23;
			}
		}
	}
}
