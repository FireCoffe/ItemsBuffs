using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class StrangeBrew : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == 3001 &  GetInstance<ItemsBuffsConfigServer>().StrangeBrew)
			{
				item.potion = false;
			}
			if (item.type == 3001 & GetInstance<ItemsBuffsConfigServer>().ManaStrangeBrew)
			{
				item.buffType = BuffType<Buffs.AutoRemoveDebuff>();
				item.buffTime = 120; //so it doesnt blink
			}
		}
	}
}
