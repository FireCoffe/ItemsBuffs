using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class NightmarePickaxe : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().NightmarePickaxe == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.NightmarePickaxe)
			{
                item.damage = 11;
			}
		}
	}
}
