using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class FlowerofFire : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.FlowerofFire)
			{
                item.mana = 10;	
			}
		}
	}
}
