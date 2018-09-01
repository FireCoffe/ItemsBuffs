using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Muramasa : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Muramasa)
			{
                item.knockBack = 3f;
                item.damage = 22;
			}
		}
	}
}
