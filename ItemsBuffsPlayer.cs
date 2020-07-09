using ItemsBuffs.Buffs;
using ItemsBuffs.Items;
using ItemsBuffs.Items.Tools;
using ItemsBuffs.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace ItemsBuffs
{
    public class ItemsBuffsPlayer : ModPlayer
    {

        public bool OrbofLight = false;
		 public bool StarFall = false;


        public override void ResetEffects()
        {
            OrbofLight = false;




        }
        
		/*public override TagCompound Save() {
			// Read https://github.com/tModLoader/tModLoader/wiki/Saving-and-loading-using-TagCompound to better understand Saving and Loading data.
			return new TagCompound {
				// {"somethingelse", somethingelse}, // To save more data, add additional lines
				{"StarFall", StarFall},
			};
			//note that C# 6.0 supports indexer initializers
			//return new TagCompound {
			//	["score"] = score
			//};
		}

	    public override void Load(TagCompound tag) {
			StarFall = tag.GetBool("StarFall");
		}
       	public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
			ModPacket packet = mod.GetPacket();
		//	packet.Write((byte)ItemsBuffsPlayerSyncPlayer);
			packet.Write((byte)player.whoAmI);
			packet.Write(StarFall);
			packet.Send(toWho, fromWho);
		} */
        public override void clientClone(ModPlayer clientClone)
        {
						ItemsBuffsPlayer clone = clientClone as ItemsBuffsPlayer;
        }
	

    }
}