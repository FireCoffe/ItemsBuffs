using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class SlimeStaff : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().SlimeStaff == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.SlimeStaff)
			{
                item.mana = 0;
			}
		}
	}
}
