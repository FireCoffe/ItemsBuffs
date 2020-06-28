using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class PossessedHatchet : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().PossessedHatchet;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.PossessedHatchet)
			{
                item.damage = 90;
			}
		}
	}
}
