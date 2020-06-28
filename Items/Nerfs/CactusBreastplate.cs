using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class CactusBreastplate : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().CactusBreastplate;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == 895)
			{
				item.defense = 2;
			}
		}
	}
}
