using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class Vilethorn : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.Vilethorn)
			{
                item.mana = 5;
			}
		}
	}
}
