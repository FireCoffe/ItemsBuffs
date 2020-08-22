using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Flamarang : GlobalItem
	{
	    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Flamarang == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Flamarang)
			{
                item.damage = 37;
			}
		}
	}
}
