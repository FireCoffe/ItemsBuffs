using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;


namespace ItemsBuffs.Items.Nerfs
{
	public class BoneJavelin : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().BoneJavelin == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 3378)
			{
				item.damage = 29;
		}
	}
}
	}