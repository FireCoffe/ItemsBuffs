using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class BookofSkulls : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BookofSkulls == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BookofSkulls)
			{
                item.knockBack = 6f;
                item.damage = 35;
                item.mana = 12;	
			}
		}
	}
}
