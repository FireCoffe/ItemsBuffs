using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class ReaverShark : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().ReaverShark;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ReaverShark)
			{
                item.pick = 100;
			}
		}
	}
}
