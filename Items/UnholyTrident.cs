using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class UnholyTrident : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == 683)
			{
                item.mana = 14;
			}
		}
	}
}
