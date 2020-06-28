using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class Amazon : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Amazon;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 3281)
			{
                item.damage = 20;
			}
		}
	}
}
