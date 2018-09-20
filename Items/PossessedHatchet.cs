using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class PossessedHatchet : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.PossessedHatchet & Config.PossessedHatchet)
			{
                item.damage = 90;
			}
		}
	}
}
