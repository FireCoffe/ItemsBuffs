using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.Items
{
	public class VampireKnives : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.VampireKnives & Config.VampireKnives)
			{
                item.shoot = mod.ProjectileType("VampProj");
                item.useTime = 12;
                item.knockBack = 3.5f;
                item.useAnimation = 12;
                item.damage = 35;
			}
		}
	}
}
