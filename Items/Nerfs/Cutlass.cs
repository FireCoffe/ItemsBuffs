using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Cutlass : GlobalItem
	{
	    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Cutlass;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Cutlass)
			{
				item.damage = 51;
			}
		}
	}
}
