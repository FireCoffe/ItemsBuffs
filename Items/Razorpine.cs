using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Razorpine : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Razorpine & Config.Razorpine)
			{
                item.damage = 58;
                item.mana = 3;
			}
		}
	}
}
