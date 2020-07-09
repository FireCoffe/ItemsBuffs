using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace ItemsBuffs.Items.CalamityNerfs
{
	[AutoloadEquip(EquipType.Head)]
	public class MeteorHelmetFake : ModItem
	{
		public override void SetStaticDefaults()
		{

			DisplayName.SetDefault("True Meteorite Helmet");
			Tooltip.SetDefault("increase magic damage by 7%\n" +
	     	"\n when used with Meteor Breasplate and Meteor leggins" +
			"\n Reduce Space gun cost 0 mana" +
			"\n[c/B81515:Calamity mod]");
			//  "\n''");
		}

		public override void SetDefaults() {
			item.width = 22;
			item.height = 24;
			//item.value = 10000;
			item.rare =  8;
			item.defense = 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == 124 && legs.type == 125;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.magicDamage += 0.7f; //  7 % magic dmg
		}
		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Space gun cost 0 mana";
			player.spaceGun = true; //smh this removed the nerf
		}

		public override void AddRecipes()
		{

			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(123);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}