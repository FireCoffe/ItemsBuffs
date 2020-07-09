using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Vilethorn : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Vilethorn;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Vilethorn)
			{
                item.mana = 5;
			}
		}
	}
}
