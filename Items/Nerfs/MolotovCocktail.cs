using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class MolotovCocktail : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().MolotovCocktail == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MolotovCocktail)
			{
                item.damage = 40;
			}
		}
	}
}
