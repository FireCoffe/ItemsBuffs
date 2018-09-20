using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class CopperShortsword : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.CopperShortsword & Config.CopperShortsword)
			{
                item.damage = 7;
			}
		}
	}
}
