using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Bone : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Bone == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Bone)
			{
                item.knockBack = 4f;
                item.damage = 22;
			}
		}
	}
}
