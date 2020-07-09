using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class LesserRestorationPotion : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.LesserRestorationPotion &  GetInstance<ItemsBuffsConfigServer>().LesserRestorationPotion)
                {
				item.potion = false;
			}
		    if (item.type == ItemID.LesserRestorationPotion & GetInstance<ItemsBuffsConfigServer>().LesserResMana)
			{
				item.buffType = BuffType<Buffs.AutoRemoveDebuff>();
				item.buffTime = 120; //so it doesnt blink
			}
		}
	}
}
