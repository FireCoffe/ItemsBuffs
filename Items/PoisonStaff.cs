using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class PoisonStaff : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == 1308)
			{
                item.damage = 59;
                item.mana = 12;
			}
		}
	}
}
