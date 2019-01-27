using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class BookofSkulls : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BookofSkulls & Config.BookofSkulls)
			{
                item.knockBack = 6f;
                item.damage = 35;
                item.mana = 12;	
			}
		}
	}
}
