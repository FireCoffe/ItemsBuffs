using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class MoltenPickaxe : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MoltenPickaxe)
			{
                item.damage = 18;
			}
		}
	}
}
