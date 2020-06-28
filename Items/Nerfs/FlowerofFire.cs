using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class FlowerofFire : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().FlowerofFire;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.FlowerofFire)
			{
                item.mana = 10;	
			}
		}
	}
}
