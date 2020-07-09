using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class HornetStaff : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().HornetStaff;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.HornetStaff)
			{
                item.mana = 0;
			}
		}
	}
}
