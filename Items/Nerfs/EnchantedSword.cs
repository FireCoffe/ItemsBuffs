using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class EnchantedSword : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().EnchantedSword;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.EnchantedSword)
			{
				item.useTime = 18;
		        item.useAnimation = 18;
				item.knockBack = 5.25f;
				item.damage = 24;
			}
		}
	}
}
