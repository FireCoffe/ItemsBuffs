using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class FlowerofFire : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.FlowerofFire & Config.FlowerofFire)
			{
                item.mana = 10;	
			}
		}
	}
}
