using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.ManaPots
{
	public class GreaterManaPotion : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == 500 & GetInstance<ItemsBuffsConfigServer>().GreaterManaPotion)
			{
				item.buffType = BuffType<Buffs.AutoRemoveDebuff>();
				item.buffTime = 120; //so it doesnt blink
			}
		}
}
}
 