using IL.Terraria.ID;
using ItemsBuffs.Items.Tools;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace ItemsBuffs 
{
	/*using Terraria;  
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

		    public override bool Autoload(ref string name)
		{
			return !GetInstance<ItemsBuffsConfigServer>().itemname; this is placeholder 
		} */
	
	// ModConfigs contain Public Fields and Properties that represent the choices available to the user. 
	// Those Fields or Properties will be presented to users in the Config menu.
	// DONT use static members anywhere in this class (except for an automatically assigned field named Instance with the same Type as the ModConfig class, if you'd rather write "MyConfigClass.Instance" instead of "ModContent.GetInstance<MyConfigClass>()"), tModLoader maintains several instances of ModConfig classes which will not work well with static properties or fields.

	/// <summary>
	/// ExampleConfigServer has Server-wide effects. Things that happen on the server, on the world, or influence autoload go here
	/// ConfigScope.ServerSide ModConfigs are SHARED from the server to all clients connecting in MP.
	/// </summary>
	public class ItemsBuffsConfigServer : ModConfig
	{
		// You MUST specify a ConfigScope.
		public override ConfigScope Mode => ConfigScope.ServerSide;



		[Header("Miscellaneous")] //Miscellaneous
		[Label("[i:1326]  True Rod of Discord Ping sound")]// [i:1326]   [i:{ItemType<RodofDiscord>()}]
		[Tooltip("Disable and enable True RoD Ping sound")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool DiscordPing { get; set; }

		[Label("[i:227] Restoration Potion")]
		[Tooltip("Restoration Potion will heal 100 mana and health")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool ResPot { get; set; } 

		[Label("[i:115]  Orb of Light")]
		[Tooltip("disable and enable crafting of better version of shadow orb")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool OrbofLightItem { get; set; } 

		[Label("[i:115]  Orb of Light AI")]
		[Tooltip("Toggle between orb ai and orb on chain ai\n" +
		"On = orb on chain ai, Off = shadow orb ai")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool OrbofLightAI { get; set; } 

		[Label("[i:65]  Starfury")]
		[Tooltip("enable and disable crafting of unnerfed Starfury")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool StarFury { get; set; } 

		[Label("[i:555]  Star Flower")]
		[Tooltip("enable and disable crafting of Star flower")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool StarFlower { get; set; } 

		[Label("[i:3224]  Wormy Scarf")]
		[Tooltip("enable and disable crafting of unnerfed Worm Scarf\n" +
		"it does give 17% dmg rdc instead of 10 % , Calamity mod")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool WS { get; set; } 

		[Label("[i:123] True Meteor Helmet")]
		[Tooltip("enable and disable crafting of unnerfed Meteorite helmet\n" +
		"When worn with breastplate and legs. it will make space gun cost 0 mana, Calamity mod")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool TMH { get; set; } 
	/*	[Label("[i:3029] Deadelus stormbow")]
		[Tooltip("enable and disable craft of unnerfed Deadelus stormbow item")]
		[ReloadRequired]
		public bool StormBow { get; set; }  */

		[Header("Crafting Recipes")] //Crafting recipes  [i:3507]  
		[Label("[i:227] Restoration Potion Crafting recipe")]
		[Tooltip("enable and disable old Restoration Potion crafting recipe")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool ResPotCraft { get; set; } 

		[Label("[i:149]  Nerfs books Crafting")]
		[Tooltip("disable and enable Crafting of Nerfs books, also disable crafting of lunar chest")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool BookCraft { get; set; } 

		/*[Label("[i:3281]  Amazon 1.3 Crafting Recipe")]
		[Tooltip("Disable and enable 1.3 Amazon Recipe")]
		[ReloadRequired]
		public bool AmazonCraft { get; set; }  */

		[Label("[i:1218]  Titanium armor 1.2 Crafting Recipe")]
		[Tooltip("Disable and enable Titanium armor 1.2 Recipe")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool TitaniumCraft { get; set; } 

		[Label("[i:990]  Pickaxe Axe 1.2 Crafting Recipe")]
		[Tooltip("Disable and enable Pickaxe Axe 1.2 Recipe")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool PickaxeAxeCrafting { get; set; } 

		[Label("[i:2590]  Molotov Cocktail 1.2 Crafting Recipe")]
		[Tooltip("Disable and enable Molotov Cocktail 1.2 Recipe")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool MolotovCocktailCraft { get; set; } 

		[Header("Mod Rods of Discord")] // RoDs
		[Label("[i:1326]  Rod of Discord - The True version")]
		[Tooltip("Enable or Disable crafting recipe of this RoD - The True version\n" +
		"Doesnt inflict Chaos State on use")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool RMeme { get; set; } 

        [Label("[i:1326]  Rod of Discord - Vanilla")]
		[Tooltip("Enable or Disable crafting recipe of this RoD - Vanilla version\n" +
		"Doesnt inflict Chaos State on use")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool RVanilla { get; set; } 

		[Header("Mod Potions")] // Mod Potions
		[Label("[i:294]  Staraise Potion")]
		[Tooltip("Enable or Disable crafting This Potion, it give immunity to Mana sickness")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool SP { get; set; } 

		[Label("[i:2351]  Chaos Aura Potion")]
		[Tooltip("Enable or Disable crafting of This Potion, it give immunity to Chaos State sickness")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool CAP { get; set; } 

		[Header("Mana Potions")] // Mana Potions
		[Label("[i:110]  Lesser Mana Potion")]
		[Tooltip("Enable and Disable Mana Sickness for this M. Potion")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool LesserManaPotion { get; set; } 

		[Label("[i:226]  Lesser Restoration Potion")]
		[Tooltip("Enable and Disable Mana Sickness for this M. an H. Potion")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool LesserResMana { get; set; } 

		[Label("[i:189]  Mana Potion")]
		[Tooltip("Enable and Disable Mana Sickness for this M. Potion")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool ManaPotion { get; set; } 

		[Label("[i:227] Restoration Potion")]
		[Tooltip("Enable and Disable Mana Sickness for this M. an H. Potion")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool ResMana { get; set; } 

		[Label("[i:500]  Greater Mana Potion")]
		[Tooltip("Enable and Disable Mana Sickness for this M. Potion")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool GreaterManaPotion { get; set; } 

	    [Label("[i:2209]  Super Mana Potion")]
		[Tooltip("Enable and Disable Mana Sickness for this M. Potion")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool SuperManaPotion { get; set; } 

	    [Label("[i:3001]  Strange Brew")]
		[Tooltip("Enable and Disable Mana Sickness for this Strange Brew")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool ManaStrangeBrew { get; set; } 

		[Header("Global healing Potions - affect all Healing Potions")] // Global Pots
		[Label("[i:3544]  Global Healing Potions")]
		[Tooltip("Remove Potion sickness from all Healing Potions Including Potions from mods \n" +
		"Note: Quick heal will dont work for all Healing Potions, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool GHP { get; set; } 

		[Header("Healing Potions and Items")] 	//heal pots
		[Label("[i:5]  Mushroom")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing item \n" +
		"Note: Quick heal will dont work for this Healing Potion, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool Mushroom { get; set; } 

		[Label("[i:126]  Bottled Water")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing bottle \n" +
		"Note: Quick heal will dont work for this Healing Bottle, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool BottledWater{ get; set; } 

		[Label("[i:1134]  Bottled Honey")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing bottle \n" +
		"Note: Quick heal will dont work for this Healing Bottle, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool BottledHoney { get; set; } 

	/*	[Label("[i:2314]  Honeyfin")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing fish")]
		[DefaultValue(true)]
		[ReloadRequired]
		public bool Honeyfin { get; set; }  */

		[Label("[i:3001]  Strange Brew")]
		[Tooltip("Enable and Disable Potion Sickness for this Strange Brew \n" +
		"Note: Quick heal will dont work for this Healing Potion, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool StrangeBrew { get; set; } 

		[Label("[i:28]  Lesser Healing Potion")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing Potion. \n" +
		"Note: Quick heal will dont work for this Healing Potion, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool LesserHealingPotion { get; set; } 

		[Label("[i:226]  Lesser Restoration Potion")]
		[Tooltip("Enable and Disable Potion Sicknesss for this Healing Potion. \n" +
		"Note: Quick heal will dont work for this Healing Potion, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool LesserRestorationPotion { get; set; } 

		[Label("[i:188]  Healing Potion")]
		[Tooltip("Enable and Disable Potion Sicknesss for this Healing Potion \n" +
		"Note: Quick heal will dont work for this Healing Potion, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool HealingPotion { get; set; } 

		[Label("[i:227]  Restoration Potion")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing Potion \n" +
		"Note: Quick heal will dont work for this Healing Potion, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool RestorationPotion { get; set; } 

		[Label("[i:2314]  Honeyfin")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing fish \n" +
		"Note: Quick heal will dont work for this Healing Potion , if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool Honeyfin { get; set; } 

		[Label("[i:499]  Greater Healing Potion")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing Potion \n" +
		"Note: Quick heal will dont work for this Healing Potion, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool GreaterHealingPotion { get; set; } 

		[Label("[i:3544]  Super Healing Potion")]
		[Tooltip("Enable and Disable Potion Sickness for this Healing Potion \n" +
		"Note: Quick heal will dont work for this Healing Potion, if potion sickness is disabled")]
		[DefaultValue(false)]
		[ReloadRequired]
		public bool SuperHealingPotion { get; set; } 

		[Header("Nerfs")]
	/*	[Label("[i:3281]  Amazon")]
		[Tooltip("damage is increased to 20 instead of 18, 1.4")]
		[ReloadRequired]
		public bool Amazon { get; set; } */
		//$"message {variable}" [i:3531]
		// You'll notice this next one is a Property instead of a field. That works too.
	// Here we see an attribute added by tModLoader: LabelAttribute. This one allows us to add a label so the user knows more about the setting they are changing. Without a label, the name of the field or property is displayed.
		[Label("[i:157]  Aqua Scepter")]
	//	[i:112]
		// Similar to Label, this sets the tooltip. Tooltips are useful for slightly longer and more detailed explanations of config options.
		[Tooltip("Use 4 mana instead of 6 mana")]
		// ReloadRequired hints that if this value is changed, a reload is required for the mod to properly work. 
		// Failure to properly use ReloadRequired will cause many, many problems including ID desync.
		[ReloadRequired]
		
		public bool AquaScepter { get; set; }

		[Label("[i:1324] Bananarang")]
		[Tooltip("Decreased use time to 7 instead of 13")]
		[ReloadRequired]
		public bool Bananarang { get; set; }

	/*	[Label("[i:723]  Beam Sword")] enable in 1.4
		[Tooltip("Use time is decreased to 15 instead of 20")]
		[ReloadRequired]
		public bool BeamSword { get; set; } 

		[Label("[i:1123]  Bee Keeper")]
		[Tooltip("Have autoswing,damage 26, knockback is increased to 5.3 , 1.4")]
		[ReloadRequired]
		public bool Beekeeper { get; set; } */

		[Label("[i:1931]  Blizzard Staff")]
		[Tooltip("Use 5 mana instead of 9")]
		[ReloadRequired]
		public bool BlizzardStaff { get; set; }

		[Label("[i:163]  Blue Moon")] //remove when 1.4 comes out
		[Tooltip("Does 30 damage instead of 23 damage")]
		[ReloadRequired]
		public bool BlueMoon { get; set; }

		[Label("[i:3378]  Bone Javelin")]
		[Tooltip("does 29 damage instead of 20, 1.4")]
		[ReloadRequired]
		public bool BoneJavelin { get; set; } 

		[Label("[i:154]  Bone")]
		[Tooltip("knockback is increased from 2 to 4 and dmg is 22 instead of 20")]
		[ReloadRequired]
		public bool Bone { get; set; }

		[Label("[i:1313]  Book of Skulls")]
		[Tooltip("does 35 dmg instead of 29, mana cost is 12 instead of 18, knockback is 6 instead of 3.5")]
		[ReloadRequired]
		public bool BookofSkulls { get; set; }

		/*[Label("[i:895]  Cactus Breastplate")]
		[Tooltip("have 2 defense instead of 1 defense, 1.4")]
		[ReloadRequired]
		public bool CactusBreastplate { get; set; }

*	[Label("[i:882]  Cactus Pickaxe")]
		[Tooltip("does 5 dmg instead of 4, 1.4")]
		[ReloadRequired]
		public bool CactusPickaxe { get; set; }

		[Label("[i:881]  Cactus Sword")]
		[Tooltip("does 9 dmg instead of 8 , have use time of 25 instead of 32, knockback 5 instead of 4.5")]
		[ReloadRequired]
		public bool CactusSword { get; set; }

		[Label("[i:3546]   Celebration")]
		[Tooltip("does 65 dmg instead of 25 dmg and have 10% crit chance")]
		[ReloadRequired]
		public bool Celebration { get; set; }

		[Label("[i:3283]  Chik")]
		[Tooltip("does 39 dmg instead of 38 dmg")]
		[ReloadRequired]
		public bool Chik { get; set; } */

		[Label("[i:1179]  Chlorophyte Bullet")]
		[Tooltip("it have 15 dmg instead of 10")]
		[ReloadRequired]
		public bool ChlorophyteBullet { get; set; }

		[Label("[i:1231]  Chlorophyte Drill")]
		[Tooltip("have 210% pick power instead of 200% pick power")]
		[ReloadRequired]
		public bool ChlorophyteDrill { get; set; }

	/*	[Label("[i:434]  Clockwork Assault Rifle")]
		[Tooltip("does 19 dmg instead of 17 dmg")]
		[ReloadRequired]
		public bool ClockworkAssaultRifle { get; set; } */
		
		[Label("[i:3507] Copper Shortsword")]
		[Tooltip("does 7 dmg instead of 5 dmg")]
		[ReloadRequired]
		public bool CopperShortsword { get; set; }
		
		[Label("[i:518]  Crystal Storm")] //remove when 1.4 comes out
		[Tooltip("does 26 dmg instead of 25, use 4 mana instead of 5 mana")]
		[ReloadRequired]
		public bool CrystalStorm { get; set; }

		[Label("[i:672]  Cutlass")]
		[Tooltip("does 51 damage instead of 49 dmg , use time is 16 instead of 17")]
		[ReloadRequired]
		public bool Cutlass { get; set; }

		[Label("[i:272]  Demon Scythe")]
		[Tooltip("use 10 mana instead of 14 mana")]
		[ReloadRequired]
		public bool DemonScythe { get; set; }

		[Label("[i:744]  Diamond Staff")]
		[Tooltip("projectile pierce 4 enemies instead of 2")]
		[ReloadRequired]
		public bool DiamondStaff { get; set; }

		/*[Label("[i:989]  Enchanted Sword")]
		[Tooltip("does 24 dmg instead of 23 , have use time of 18 instead of 21, knockback 5.25 instead of 4.25, 1.4")]
		[ReloadRequired]
		public bool EnchantedSword { get; set; } 

		[Label("[i:2608]  Falcon Blade")]
		[Tooltip("does 30 dmg instead of 25, have use time 15 instead of 20, 1.4")]
		[ReloadRequired]
		public bool FalconBlade { get; set; } 

		[Label("[i:3013]  Fetid Baghnakhs")]
		[Tooltip("does 70 dmg instead of 60 dmg, use time is 7 instead of 8")]
		[ReloadRequired]
		public bool FetidBaghnakhs { get; set; } */

		[Label("[i:119]  Flamarang")]
		[Tooltip("does 37 dmg instead of 32")]
		[ReloadRequired]
		public bool Flamarang { get; set; }

	/*	[Label("[i:218]  Flamelash")]
		[Tooltip("have 47 dmg instead of 36 and use 12 mana instead of 18 ,1.4")]
		[ReloadRequired]
		public bool Flamelash { get; set; } */

		[Label("[i:112]  Flower of Fire")]
		[Tooltip("use 10 mana instead of 15")]
		[ReloadRequired]
		public bool FlowerofFire { get; set; }

		[Label("[i:726]  Frost Staff")]
		[Tooltip("does 53 dmg instead of 46 , use 10 mana instead of 14")]
		[ReloadRequired]
		public bool FrostStaff { get; set; }

		[Label("[i:1336]  Golden Shower")]
		[Tooltip("projectile have infinite penetration instead of 5 , have 28 dmg instead of 21 dmg")]
		[ReloadRequired]
		public bool GoldenShower { get; set; }

		[Label("[i:1295]  Heat Ray")] //remove this nerf in 1.4 , Can no longer pierce and hit multiple enemies.
		[Tooltip("Doesnt use any mana instead of 8 mana")]
		[ReloadRequired]
		public bool HeatRay { get; set; }

		[Label("[i:2364]  Hornet Staff")]
		[Tooltip("doesnt use any mana instead of 10 mana")]
		[ReloadRequired]
		public bool HornetStaff { get; set; }

		[Label("[i:2365]  Imp Staff")] //removed 1.4 nerf Damage decreased from 21 to 17. enable in 1.4
		[Tooltip("doesnt use any mana instead of 10, does 21 dmg instead of 17 , 1.4")]
		[ReloadRequired]
		public bool ImpStaff { get; set; } 

		[Label("[i:7]  Iron Hammer")]
		[Tooltip("Hammer power is 45% instead of 40%")]
		[ReloadRequired]
		public bool IronHammer { get; set; }

		[Label("[i:1178]  Leaf Blower")]
		[Tooltip("doesnt use any mana instead of 4")]
		[ReloadRequired]
		public bool LeafBlower { get; set; }

		[Label("[i:113]  Magic Missile")]
		/*
		 * Use Time increased from 20 to 30.
           Mana Cost increased from 12 to 18. this nerf to be removed
		*/
		[Tooltip("does 32 dmg instead of 27 , use 10 mana instead of 18")]
		[ReloadRequired]
		public bool MagicMissile { get; set; }

		[Label("[i:3269]  Medusa Head")]
		[Tooltip("have 45 dmg instead of 40 dmg, use 4 mana instead of 15 , 1.4")]
		[ReloadRequired]
		public bool MedusaHead { get; set; }

		[Label("[i:2590]  Molotov Cocktail")] //remove crafting nerf or add it
		[Tooltip("does 40 dmg instead of 24 dmg")]
		[ReloadRequired]
		public bool MolotovCocktail { get; set; }

		[Label("[i:122]  Molten Pickaxe")]
		[Tooltip("does 18 dmg instead of 12 dmg")]
		[ReloadRequired]
		public bool MoltenPickaxe { get; set; }

		[Label("[i:155]  Muramasa")]
		[Tooltip("does 22 dmg instead of 21 dmg , knockback 3 instead of 1")]
		[ReloadRequired]
		public bool Muramasa { get; set; }

		[Label("[i:3476]  Nebula Arcanum")]
		[Tooltip("does 80 dmg instead of 70 dmg")]
		[ReloadRequired]
		public bool NebulaArcanum { get; set; }

		[Label("[i:103]  Nightmare Pickaxe")]
		[Tooltip("does 11 dmg instead of 9")]
		[ReloadRequired]
		public bool NightmarePickaxe { get; set; }

		[Label("[i:1947]  North Pole")] //remove 1.2 nerf to be done
		[Tooltip("does 75 dmg instead of 73")]
		[ReloadRequired]
		public bool NorthPole { get; set; }

		[Label("[i:3540]  Phantasm")]
		[Tooltip("does 70 dmg instead of 50")]
		[ReloadRequired]
		public bool Phantasm { get; set; }

		[Label("[i:219]  Phoenix Blaster")]
		[Tooltip("does 28 dmg instead of 23, does knockback 4 instead of 2")]
		[ReloadRequired]
		public bool PhoenixBlaster { get; set; }

		[Label("[i:287]  Poisoned Knife")]
		[Tooltip("does 15 dmg instead of 14dmg")]
		[ReloadRequired]
		public bool PoisonedKnife { get; set; }

		[Label("[i:1308]  Poison Staff")] //remove in 1.4
		[Tooltip("does 59 dmg instead of 43,use 12 mana instead of 22 mana")]
		[ReloadRequired]
		public bool PoisonStaff { get; set; }

		[Label("[i:1122]  Possessed Hatchet")]
		[Tooltip("does 90 dmg instead of 80 dmg")]
		[ReloadRequired]
		public bool PossessedHatchet { get; set; }

		[Label("[i:495]  Rainbow Rod")]
		[Tooltip("use 10 mana instead of 25, does 74 dmg instead of 50, use time 18 instead of 25")]
		[ReloadRequired]
		public bool RainbowRod { get; set; }

		[Label("[i:1930]  Razorpine")]
		[Tooltip("does 58 dmg instead of 48 dmg, use 3 mana instead of 5 mana")]
		[ReloadRequired]
		public bool Razorpine { get; set; }
		
	/*	[Label("[i:2341]  Reaver Shark")]
		[Tooltip("Reaver shark pickaxe power is now 100% instead of 59% , 1.4")]
		[ReloadRequired]
		public bool ReaverShark { get; set; } */

		[Label("[i:3287]  Reds Throw")]
		[Tooltip("does 180 dmg instead of 70 dmg")]
		[ReloadRequired]
		public bool RedsThrow { get; set; }

		[Label("[i:1444]  Shadowbeam Staff")]
		[Tooltip("does 55 dmg instead of 53 dmg , use 6 mana instead of 7 mana")]
		[ReloadRequired]
		public bool ShadowbeamStaff { get; set; }

		/*[Label("[i:3787]  Sky Fracture")]
		[Tooltip("use 14 mana instead of 17 , 1.4")]
		[ReloadRequired]
		public bool SkyFracture { get; set; } */

		[Label("[i:1309]  Slime Staff")]
		[Tooltip("use 0 mana instead of 10")]
		[ReloadRequired]
		public bool SlimeStaff { get; set; }

		[Label("[i:1503]  Spectre Hood")]
		[Tooltip("doesnt decrease magic damage by 40% instead does 10% magic dmg and critical strike chance")]
		[ReloadRequired]
		public bool SpectreHood { get; set; }

	/*	[Label("[i:3800]  Squire's Great Helm")]
		[Tooltip("heal 4hp per second instead of 2hp per second, 1.4")]
		[ReloadRequired]
		public bool SquiresGreatHelm { get; set; } */

		[Label("[i:213]  Staff of Regrowth")]
		[Tooltip("does 20 dmg instead of 7 , making staff more useful as melee weapon")]
		[ReloadRequired]
		public bool StaffofRegrowth { get; set; }

		[Label("[i:197]  Star Cannon")]
		[Tooltip("does 75 dmg instead of 55 dmg")]
		[ReloadRequired]
		public bool StarCannon { get; set; }

		[Label("[i:3531]  Stardust Dragon Staff")]
		[Tooltip("does 60 dmg instead of 40 dmg")]
		[ReloadRequired]
		public bool StardustDragonStaff { get; set; }

		[Label("[i:220]  Sunfury")] //remove in 1.4
		[Tooltip("does 40 dmg instead of 35")]
		[ReloadRequired]
		public bool Sunfury { get; set; }

	/*	[Label("[i:2888]  The Bee's Knees")]
		[Tooltip("does 26 dmg instead of 23, use time is 23 instead of 24, 1.4")]
		[ReloadRequired]
		public bool TheBeesKnees { get; set; } */

		[Label("[i:683]  Unholy Trident")] 
		[Tooltip("use 14 mana instead of 25")]
		[ReloadRequired]
		public bool UnholyTrident { get; set; }

	/*	[Label("[i:3872]  Valhalla Knight's Breastplate")] 
		[Tooltip("heals 8 hp per second instead of 4hp per second, 1.4")]
		[ReloadRequired]
		public bool ValhallaKnightsBreastplate { get; set; } */
		/*
		 * Use time decreased from 22 to 17.
Mana cost decreased from 25 to 19.
Damage increased from 73 to 95. */

		[Label("[i:3288]  Valkyrie Yoyo")]
		[Tooltip("does 180 dmg instead of 70 , does 8.5 knockback instead of 4.5 knb")]
		[ReloadRequired]
		public bool ValkyrieYoyo { get; set; }

		[Label("[i:1569]  Vampire Knives")]
		[Tooltip("Vampire knifes heal without cooldown around 10 hp per second , have use time of 12 instead of 16,\n" +
		"does 35 dmg instead of 29 dmg")]
	//\n" +
		//	test")]
		[ReloadRequired]
		public bool VampireKnives { get; set; }

		[Label("[i:64]  Vilethorn")]
		[Tooltip("use 5 mana instead of 10")]
		[ReloadRequired]
		public bool Vilethorn { get; set; }

		[Label("[i:3475]  Vortex Beater")]
		[Tooltip("does 70 dmg instead of 50 dmg")]
		[ReloadRequired]
		public bool VortexBeater { get; set; }

		// AcceptClientChanges is called on the server when a Client player attempts to change ServerSide settings in-game. By default, client changes are accepted. (As long as they don't necessitate a Reload)
		// With more effort, a mod could implement more control over changing mod settings.
		public override bool AcceptClientChanges(ModConfig pendingConfig, int whoAmI, ref string message)
		{
			return true;
		}

	}
}