using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class AquaScepter : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().AquaScepter == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.AquaScepter)
                {
                item.mana = 4;
			}
		}
	}
}