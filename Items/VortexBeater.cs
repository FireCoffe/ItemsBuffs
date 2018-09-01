using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class VortexBeater : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.VortexBeater)
			{
                item.damage = 70;
			}
		}
	}
}
