using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Flamarang : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Flamarang & Config.Flamarang)
			{
                item.damage = 37;
			}
		}
	}
}
