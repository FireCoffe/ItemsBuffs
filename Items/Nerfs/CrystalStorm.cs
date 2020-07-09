using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class CrystalStorm : GlobalItem
	{
	    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().CrystalStorm;
		}
		public override void SetDefaults(Item item)
		{

			if (item.type == ItemID.CrystalStorm)
			{
                item.damage = 26;
			}
		}
	}
}
