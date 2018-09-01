using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class RainbowRod : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.RainbowRod)
			{
                item.mana = 10;
			}
		}
	}
}
