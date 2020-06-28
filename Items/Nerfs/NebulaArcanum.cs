using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class NebulaArcanum : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().NebulaArcanum;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.NebulaArcanum)
			{
                item.damage = 80;
			}
		}
	}
}
