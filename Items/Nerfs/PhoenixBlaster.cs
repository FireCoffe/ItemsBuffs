using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class PhoenixBlaster : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().PhoenixBlaster == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.PhoenixBlaster)

            {
                item.knockBack = 4f;
                item.damage = 28;
			}
		}
	}
}
