using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class MedusaHead : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MedusaHead)
			{
                item.mana = 8;
			}
		}
	}
}
