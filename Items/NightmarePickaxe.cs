using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class NightmarePickaxe : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.NightmarePickaxe)
			{
                item.damage = 11;
			}
		}
	}
}
