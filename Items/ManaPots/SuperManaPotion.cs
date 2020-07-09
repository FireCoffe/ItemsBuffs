using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.ManaPots
{
	public class SuperManaPotion : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == 2209 & GetInstance<ItemsBuffsConfigServer>().SuperManaPotion)
			{
				item.buffType = BuffType<Buffs.AutoRemoveDebuff>();
				item.buffTime = 120; //so it doesnt blink
			}
		}
    }
}