using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace ItemsBuffs.Items.HealPots
{
	public class BottledWater : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.BottledWater &  GetInstance<ItemsBuffsConfigServer>().BottledWater) //this is heal potion too lol 
			{
				item.potion = false;
			}
		}
	}
}
