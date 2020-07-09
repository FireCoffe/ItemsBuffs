using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class ChlorophyteDrill : GlobalItem
	{
	    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().ChlorophyteDrill;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ChlorophyteDrill)
			{
				item.pick = 210;
			}
		}
	}
}
