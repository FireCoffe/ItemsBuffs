using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class SlimeStaff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.SlimeStaff & Config.SlimeStaff)
			{
                item.mana = 0;
			}
		}
	}
}
