using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class FetidBaghnakhs : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().FetidBaghnakhs;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 3013)
			{
                item.useTime = 7;
                item.useAnimation = 7;
                item.damage = 70;
			}
		}
	}
}
