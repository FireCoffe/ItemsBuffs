using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class RainbowRod : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().RainbowRod;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.RainbowRod)
			{
                item.mana = 10;
				item.useTime = 18;
		        item.useAnimation = 18;
				item.damage = 74;
			}
		}
	}
}
