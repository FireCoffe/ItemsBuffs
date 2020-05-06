using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class BottledHoney : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BottledHoney &  Config.NoCooldownForHealItems)
                {
				item.potion = false;
			}
		}
	}
}
