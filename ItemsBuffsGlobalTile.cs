using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs
{
	internal sealed class ItemsBuffsGlobalTile : GlobalTile
	{
		public override bool Drop(int i, int j, int type)
		{
			if (type == 31 & Config.OrbHeartBossSpawn) //how do i make it to drop one item instead of five ???
        {
            Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("HeartofLife"), Main.rand.Next(1, 1), false, 0, false, false);
        }
			return true;
		}
	}
}
