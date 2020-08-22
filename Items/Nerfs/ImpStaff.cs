using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class ImpStaff : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().ImpStaff == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ImpStaff)
			{
                item.mana = 0;
				item.damage = 21;
			}
		}
	}
}
