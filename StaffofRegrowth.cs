using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class StaffofRegrowth : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.StaffofRegrowth & Config.StaffofRegrowth)
			{
                item.damage = 20;
			}
		}
	}
}
