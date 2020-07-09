using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.ManaPots
{
	public class ManaPotion : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == 189 & GetInstance<ItemsBuffsConfigServer>().ManaPotion)
			{
				item.buffType = BuffType<Buffs.AutoRemoveDebuff>();
				item.buffTime = 120; //so it doesnt blink
			}
		}
}
}
 