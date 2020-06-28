using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Flamelash : GlobalItem
	{
        public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Flamelash;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Flamelash)
			{
                item.damage = 47;
				item.mana = 12; //1.4 nerf
			}
		}
	}
}
