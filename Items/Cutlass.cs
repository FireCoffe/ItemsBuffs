using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Cutlass : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Cutlass)
			{
				item.damage = 51;
			}
		}
	}
}
