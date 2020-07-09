using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class StardustDragonStaff : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().StardustDragonStaff;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.StardustDragonStaff)
			{
				item.damage = 60;
			}
		}
	}
}
