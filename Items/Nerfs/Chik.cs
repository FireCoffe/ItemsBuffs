using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class Chik : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().Chik;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Chik)
			{
				item.damage = 39;
			}
		}
	}
}
