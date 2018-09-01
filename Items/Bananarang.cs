using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Bananarang : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Bananarang)
			{
                item.useTime = 7;
                item.useAnimation = 7;
			}
		}
	}
}
