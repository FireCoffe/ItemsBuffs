using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class RestorationPotion : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.RestorationPotion &  Config.NoCooldownForHealItems)
                {
				item.potion = false;
                if (Config.RestorationPotion == true)
                {
					item.healLife = 100;
					item.healMana = 100;
				}
			}
		}
	}
}
