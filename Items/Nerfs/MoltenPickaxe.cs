using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class MoltenPickaxe : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().MoltenPickaxe == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MoltenPickaxe)
			{
                item.damage = 18;
			}
		}
	}
}
