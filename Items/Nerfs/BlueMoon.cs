using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class BlueMoon : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BlueMoon == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BlueMoon)
			{
				item.damage = 30;
			}
		}
	}
}
