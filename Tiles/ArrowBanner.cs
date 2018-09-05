﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace ItemsBuffs.Tiles {
    public class ArrowBanner : ModTile {
        public override void SetDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 12 };
            TileObjectData.newTile.StyleHorizontal = true;

            ModTranslation translation = CreateMapEntryName();
            translation.SetDefault("Luminite Arrow Banner");

            AddMapEntry(new Color(153, 204, 255), translation);

            disableSmartCursor = true;

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("ArrowBannerA"));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;

               // player.NPCBannerBuff[Item.NPCtoBanner(NPCID.VortexHornet)] = true;
                //player.NPCBannerBuff[Item.NPCtoBanner(NPCID.VortexHornetQueen)] = true;
               // player.NPCBannerBuff[Item.NPCtoBanner(NPCID.VortexLarva)] = true;
               // player.NPCBannerBuff[Item.NPCtoBanner(NPCID.VortexRifleman)] = true;
              //  player.NPCBannerBuff[Item.NPCtoBanner(NPCID.VortexSoldier)] = true;

              //  player.hasBanner = true;
            }
        }
    }
}
