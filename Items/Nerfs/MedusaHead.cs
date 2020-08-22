using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class MedusaHead : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().MedusaHead == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MedusaHead) //& Config.MedusaHead)
			{
				item.damage = 45;
                item.mana = 4;
			}
		}
	}
}
