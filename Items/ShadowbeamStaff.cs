using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class ShadowbeamStaff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ShadowbeamStaff)
			{
                item.damage = 55;
                item.mana = 6;
			}
		}
	}
}
