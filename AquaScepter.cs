using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class AquaScepter : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.AquaScepter &  Config.AquaScepter)
                {
                item.mana = 4;
			}
		}
	}
}
