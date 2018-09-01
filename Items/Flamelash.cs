using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Flamelash : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Flamelash)
			{
                item.damage = 47;
			}
		}
	}
}
