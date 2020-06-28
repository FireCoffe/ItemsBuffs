using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Razorpine : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Razorpine;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Razorpine)
			{
                item.damage = 58;
                item.mana = 3;
			}
		}
	}
}
