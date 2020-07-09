using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Phantasm : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Phantasm;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Phantasm)
			{
				item.damage = 70;
			}
		}
	}
}
