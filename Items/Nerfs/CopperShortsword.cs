using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class CopperShortsword : GlobalItem
	{
	    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().CopperShortsword;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.CopperShortsword)
			{
                item.damage = 7;
			}
		}
	}
}
