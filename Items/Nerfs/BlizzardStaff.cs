using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class BlizzardStaff : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BlizzardStaff;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BlizzardStaff)
			{
                item.mana = 5;
			}
		}
	}
}
