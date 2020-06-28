using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class CactusPickaxe : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().CactusPickaxe;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.CactusPickaxe)
			{
		        item.useAnimation = 16;
				item.useTime = 16;
                item.damage = 5;
			}
		}
	}
}
