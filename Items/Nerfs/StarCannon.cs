using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class StarCannon : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().StarCannon;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.StarCannon)
			{
                item.damage = 75;
			}
		}
	}
}
