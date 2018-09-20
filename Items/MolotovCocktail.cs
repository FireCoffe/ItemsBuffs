using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class MolotovCocktail : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.MolotovCocktail & Config.MolotovCocktail)
			{
                item.damage = 40;
			}
		}
	}
}
