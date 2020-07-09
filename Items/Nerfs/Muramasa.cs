using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class Muramasa : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Muramasa;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Muramasa)
			{
                item.knockBack = 3f;
                item.damage = 22;
			}
		}
	}
}
