using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System;
using Terraria.DataStructures;
using Terraria.Localization;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ItemsBuffs.Items.Potions;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs.Items.Potions
{
public class TeleporticPotion : ModItem //remove in 5.1
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Teleportic Potion");
			Tooltip.SetDefault("it no longer works , <right> to get your Potion back");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 26;
			item.maxStack = 30;
			item.rare = ItemRarityID.Quest;
		}

		public override bool CanRightClick() {
			return true;
		}

		public override void RightClick(Player player) {
			player.QuickSpawnItem(ItemType<ChaosAuraPotion>());
		}
	}
}