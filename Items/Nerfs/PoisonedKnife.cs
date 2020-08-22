using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class PoisonedKnife : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().PoisonedKnife == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.PoisonedKnife)
			{
				item.damage = 15;
			}
		}
	}
}
