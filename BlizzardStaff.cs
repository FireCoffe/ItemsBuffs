using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class BlizzardStaff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BlizzardStaff & Config.BlizzardStaff)
			{
                item.mana = 5;
			}
		}
	}
}
