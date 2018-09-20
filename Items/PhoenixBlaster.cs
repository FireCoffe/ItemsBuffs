using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class PhoenixBlaster : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.PhoenixBlaster & Config.PhoenixBlaster)

            {
                item.knockBack = 4f;
                item.damage = 28;
			}
		}
	}
}
