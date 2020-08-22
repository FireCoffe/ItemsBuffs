using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class ShadowbeamStaff : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().ShadowbeamStaff == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ShadowbeamStaff)
			{
                item.damage = 55;
                item.mana = 6;
			}
		}
	}
}
