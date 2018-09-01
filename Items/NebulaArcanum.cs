using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class NebulaArcanum : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.NebulaArcanum)
			{
                item.damage = 80;
			}
		}
	}
}
