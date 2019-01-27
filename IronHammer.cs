using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class IronHammer : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.IronHammer & Config.IronHammer)
			{
				item.hammer = 45;
			}
		}
	}
}
