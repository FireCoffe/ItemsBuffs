using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class DemonScythe : GlobalItem
	{
	    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().DemonScythe;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.DemonScythe)
			{
                item.mana = 10;
			}
		}
	}
}
