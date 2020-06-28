using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class PoisonStaff : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().PoisonStaff;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 1308)
			{
                item.damage = 59;
                item.mana = 12;
			}
		}
	}
}
