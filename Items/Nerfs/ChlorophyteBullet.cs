using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class ChlorophyteBullet : GlobalItem
	{
	    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().ChlorophyteBullet;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.ChlorophyteBullet)
			{
				item.damage = 15;
			}
		}
	}
}
