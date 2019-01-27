using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class CrystalStorm : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.CrystalStorm & Config.CrystalStorm)
			{
                item.damage = 26;
			}
		}
	}
}
