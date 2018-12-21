using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ItemsBuffs.NPCs
{
    public class ItemsBuffsGlobalNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
         //   if (Main.rand.Next(10) == 0)
            {
                if (npc.type == NPCID.BrainofCthulhu & Config.DefaltBossOrbHeartSpawn)
                {
                    if (Main.rand.NextFloat() < 100.00f) // 50.00% chance
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CorruptedAnvil"), Main.rand.Next(1, 1));
                }
                if (npc.type == 13 & Config.DefaltBossOrbHeartSpawn)
                {
                    if (Main.rand.NextFloat() < 100.00f) // 50.00% chance
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CorruptedAnvil"), Main.rand.Next(1, 1));
                    // Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (ItemID.TruffleWorm));
                }
            }
        }
    }
}
//   if (Main.rand.NextFloat() < 100.00f) // 50.00% chance
//Item.NewItem(npc.getRect(), ItemID.TruffleWorm, 1);