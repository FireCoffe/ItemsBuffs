using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class StaffofRegrowth : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().StaffofRegrowth == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.StaffofRegrowth)
			{
                item.damage = 20;
			}
		}
	}
}
