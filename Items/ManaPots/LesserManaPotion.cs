using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.ManaPots
{
	public class LesserManaPotion : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.LesserManaPotion & GetInstance<ItemsBuffsConfigServer>().LesserManaPotion)
			{
				item.buffType = BuffType<Buffs.AutoRemoveDebuff>();
				item.buffTime = 120; //so it doesnt blink
			}
		}
}
}
 