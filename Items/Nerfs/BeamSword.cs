using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class BeamSword : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BeamSword;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BeamSword)
			{
				item.useTime = 15;
		        item.useAnimation = 15;
			}
		}
	}
}
