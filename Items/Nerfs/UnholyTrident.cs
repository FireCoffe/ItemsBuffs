using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class UnholyTrident : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().UnholyTrident;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 683)
			{
                item.mana = 14;
			}
		}
	}
}
