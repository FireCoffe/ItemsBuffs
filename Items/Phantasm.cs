using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Phantasm : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Phantasm)
			{
				item.damage = 70;
			}
		}
	}
}
