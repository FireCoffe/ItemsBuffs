using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Bone : GlobalItem
	{
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
