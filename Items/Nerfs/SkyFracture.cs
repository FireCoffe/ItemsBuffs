using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class SkyFracture : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().SkyFracture;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.SkyFracture) //434
                {
				item.mana = 14;
			}
		}
	}
}
