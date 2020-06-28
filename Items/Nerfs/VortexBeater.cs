using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class VortexBeater : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().VortexBeater;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.VortexBeater)
			{
                item.damage = 70;
			}
		}
	}
}
