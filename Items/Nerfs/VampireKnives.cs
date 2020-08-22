using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.Nerfs
{
	public class VampireKnives : GlobalItem
	{
		public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().VampireKnives == false;
		}
		public override void SetDefaults(Item item)
		{
			if (item.type == ItemID.VampireKnives)
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
