using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class LeafBlower : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().LeafBlower;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.LeafBlower)
			{
                item.mana = 0;
			}
		}
	}
}
