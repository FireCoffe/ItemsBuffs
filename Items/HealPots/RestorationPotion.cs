using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.HealPots
{
	public class RestorationPotion : GlobalItem
	{

		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.RestorationPotion &  GetInstance<ItemsBuffsConfigServer>().RestorationPotion)
                {
				item.potion = false;
                if (GetInstance<ItemsBuffsConfigServer>().ResPot == true)
                {
					item.healLife = 100;
					item.healMana = 100;
				}

            if (item.type == ItemID.RestorationPotion & GetInstance<ItemsBuffsConfigServer>().ResMana)
			{
				item.buffType = BuffType<Buffs.AutoRemoveDebuff>();
				item.buffTime = 120; //so it doesnt blink
			}
			}
		}
	}
}
