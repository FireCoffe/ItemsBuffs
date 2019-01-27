using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class LeafBlower : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.LeafBlower & Config.LeafBlower)
			{
                item.mana = 0;
			}
		}
	}
}
