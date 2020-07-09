using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class FrostStaff : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().FrostStaff;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.FrostStaff)
			{
                item.damage = 53;
                item.mana = 10;
			}
		}
	}
}
