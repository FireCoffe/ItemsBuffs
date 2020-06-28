using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class MagicMissile : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().MagicMissile;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MagicMissile)
			{
                item.damage = 32;
				item.mana = 10;
			}
		}
	}
}
