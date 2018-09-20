using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class RedsThrow : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == 3287 & Config.RedsThrow)

            {
                item.damage = 180;
			}
		}
	}
}
