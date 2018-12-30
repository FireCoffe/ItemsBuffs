using System;
using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

public static class Config
{
    public static bool OrbHeartBossSpawn = false;
    public static bool AquaScepter = true;
    public static bool Bananarang = true;
    public static bool BlizzardStaff = true;
    public static bool BlueMoon = true;
    public static bool Bone = true;
    public static bool BookofSkulls = true;
    public static bool CopperShortsword = true;
    public static bool CrystalStorm = true;
    public static bool Cutlass = true;
    public static bool DemonScythe = true;
    public static bool DiamondStaff = true;
    public static bool Flamarang = true;
    public static bool Flamelash = true;
    public static bool FlowerofFire = true;
    public static bool FrostStaff = true;
    public static bool GoldenShower = true;
    public static bool HeatRay = true;
    public static bool HornetStaff = true;
    public static bool ChlorophyteBullet = true;
    public static bool ChlorophyteDrill = false;
    public static bool ImpStaff = true;
    public static bool IronHammer = true;
    public static bool LeafBlower = true;
    public static bool MagicMissile = true;
    public static bool MedusaHead = true;
    public static bool MolotovCocktail = true;
    public static bool MoltenPickaxe = true;
    public static bool Muramasa = true;
    public static bool NebulaArcanum = true;
    public static bool NightmarePickaxe = true;
    public static bool NorthPole = true;
    public static bool Phantasm = true;
    public static bool PhoenixBlaster = true;
    public static bool PoisonedKnife = true;
    public static bool PoisonStaff = true;
    public static bool PossessedHatchet = true;
    public static bool RainbowRod = true;
    public static bool Razorpine = true;
    public static bool RedsThrow = true;
    public static bool ShadowbeamStaff = true;
    public static bool SlimeStaff = true;
    public static bool SpectreHood = true;
    public static bool StaffofRegrowth = true;
    public static bool StarCannon = true;
    public static bool StardustDragonStaff = true;
    public static bool Sunfury = true;
    public static bool UnholyTrident = true;
    public static bool ValkyrieYoyo = true;
    public static bool VampireKnives = true;
    public static bool Vilethorn = true;
    public static bool VortexBeater = true;


    private static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "Removed Nerfs of items v3.3.json");

    private static Preferences Configuration = new Preferences(Config.ConfigPath, false, false);

    public static void Load()
    {
        if (!Config.ReadConfig())
        {
            ErrorLogger.Log("Failed to read Removed nerfs of items config file! Recreating config...");
            Config.CreateConfig();
        }
    }

    private static bool ReadConfig()
    {
        bool result;
        if (Config.Configuration.Load())
        {
            Config.Configuration.Get<bool>("OrbHeartBossSpawn", ref Config.OrbHeartBossSpawn);
            Config.Configuration.Get<bool>("AquaScepter", ref Config.AquaScepter);
            Config.Configuration.Get<bool>("Bananarang", ref Config.Bananarang);
            Config.Configuration.Get<bool>("BlizzardStaff", ref Config.BlizzardStaff);
            Config.Configuration.Get<bool>("BlueMoon", ref Config.BlueMoon);
            Config.Configuration.Get<bool>("Bone", ref Config.Bone);
            Config.Configuration.Get<bool>("BookofSkulls", ref Config.BookofSkulls);
            Config.Configuration.Get<bool>("CopperShortsword", ref Config.CopperShortsword);
            Config.Configuration.Get<bool>("CrystalStorm", ref Config.CrystalStorm);
            Config.Configuration.Get<bool>("Cutlass", ref Config.Cutlass);
            Config.Configuration.Get<bool>("DemonScythe", ref Config.DemonScythe);
            Config.Configuration.Get<bool>("DiamondStaff", ref Config.DiamondStaff);
            Config.Configuration.Get<bool>("Flamarang", ref Config.Flamarang);
            Config.Configuration.Get<bool>("Flamelash", ref Config.Flamelash);
            Config.Configuration.Get<bool>("FlowerofFire", ref Config.FlowerofFire);
            Config.Configuration.Get<bool>("FrostStaff", ref Config.FrostStaff);
            Config.Configuration.Get<bool>("GoldenShower", ref Config.GoldenShower);
            Config.Configuration.Get<bool>("HeatRay", ref Config.HeatRay);
            Config.Configuration.Get<bool>("HornetStaff", ref Config.HornetStaff);
            Config.Configuration.Get<bool>("ChlorophyteBullet", ref Config.ChlorophyteBullet);
            Config.Configuration.Get<bool>("ChlorophyteDrill", ref Config.ChlorophyteDrill);
            Config.Configuration.Get<bool>("ImpStaff", ref Config.ImpStaff);
            Config.Configuration.Get<bool>("IronHammer", ref Config.IronHammer);
            Config.Configuration.Get<bool>("LeafBlower", ref Config.LeafBlower);
            Config.Configuration.Get<bool>("MagicMissile", ref Config.MagicMissile);
            Config.Configuration.Get<bool>("MedusaHead", ref Config.MedusaHead);
            Config.Configuration.Get<bool>("MolotovCocktail", ref Config.MolotovCocktail);
            Config.Configuration.Get<bool>("MoltenPickaxe", ref Config.MoltenPickaxe);
            Config.Configuration.Get<bool>("Muramasa", ref Config.Muramasa);
            Config.Configuration.Get<bool>("NebulaArcanum", ref Config.NebulaArcanum);
            Config.Configuration.Get<bool>("NightmarePickaxe", ref Config.NightmarePickaxe);
            Config.Configuration.Get<bool>("NorthPole", ref Config.NorthPole);
            Config.Configuration.Get<bool>("Phantasm", ref Config.Phantasm);
            Config.Configuration.Get<bool>("PhoenixBlaster", ref Config.PhoenixBlaster);
            Config.Configuration.Get<bool>("PoisonedKnife", ref Config.PoisonedKnife);
            Config.Configuration.Get<bool>("PoisonStaff", ref Config.PoisonStaff);
            Config.Configuration.Get<bool>("PossessedHatchet", ref Config.PossessedHatchet);
            Config.Configuration.Get<bool>("RainbowRod", ref Config.RainbowRod);
            Config.Configuration.Get<bool>("Razorpine", ref Config.Razorpine);
            Config.Configuration.Get<bool>("RedsThrow", ref Config.RedsThrow);
            Config.Configuration.Get<bool>("ShadowbeamStaff", ref Config.ShadowbeamStaff);
            Config.Configuration.Get<bool>("SlimeStaff", ref Config.SlimeStaff);
            Config.Configuration.Get<bool>("SpectreHood", ref Config.SpectreHood);
            Config.Configuration.Get<bool>("StaffofRegrowth", ref Config.StaffofRegrowth);
            Config.Configuration.Get<bool>("StarCannon", ref Config.StarCannon);
            Config.Configuration.Get<bool>("StardustDragonStaff", ref Config.StardustDragonStaff);
            Config.Configuration.Get<bool>("Sunfury", ref Config.Sunfury);
            Config.Configuration.Get<bool>("UnholyTrident", ref Config.UnholyTrident);
            Config.Configuration.Get<bool>("ValkyrieYoyo", ref Config.ValkyrieYoyo);
            Config.Configuration.Get<bool>("VampireKnives", ref Config.VampireKnives);
            Config.Configuration.Get<bool>("Vilethorn", ref Config.Vilethorn);
            Config.Configuration.Get<bool>("VortexBeater", ref Config.VortexBeater);
            result = true;
        }
        else
        {
            result = false;
        }
        return result;
    }

    private static void CreateConfig()
    {
        Config.Configuration.Clear();
        Config.Configuration.Put("OrbHeartBossSpawn", Config.OrbHeartBossSpawn);
        Config.Configuration.Put("AquaScepter", Config.AquaScepter);
        Config.Configuration.Put("Bananarang", Config.Bananarang);
        Config.Configuration.Put("BlizzardStaff", Config.BlizzardStaff);
        Config.Configuration.Put("BlueMoon", Config.BlueMoon);
        Config.Configuration.Put("Bone", Config.Bone);
        Config.Configuration.Put("BookofSkulls", Config.BookofSkulls);
        Config.Configuration.Put("CopperShortsword", Config.CopperShortsword);
        Config.Configuration.Put("CrystalStorm", Config.CrystalStorm);
        Config.Configuration.Put("Cutlass", Config.Cutlass);
        Config.Configuration.Put("DemonScythe", Config.DemonScythe);
        Config.Configuration.Put("DiamondStaff", Config.DiamondStaff);
        Config.Configuration.Put("Flamarang", Config.Flamarang);
        Config.Configuration.Put("Flamelash", Config.Flamelash);
        Config.Configuration.Put("FlowerofFire", Config.Flamarang);
        Config.Configuration.Put("FrostStaff", Config.FrostStaff);
        Config.Configuration.Put("GoldenShower", Config.GoldenShower);
        Config.Configuration.Put("HeatRay", Config.HeatRay);
        Config.Configuration.Put("HornetStaff", Config.HornetStaff);
        Config.Configuration.Put("ChlorophyteBullet", Config.ChlorophyteBullet);
        Config.Configuration.Put("ChlorophyteDrill", Config.ChlorophyteDrill);
        Config.Configuration.Put("ImpStaff", Config.ImpStaff);
        Config.Configuration.Put("IronHammer", Config.IronHammer);
        Config.Configuration.Put("LeafBlower", Config.LeafBlower);
        Config.Configuration.Put("MagicMissile", Config.MagicMissile);
        Config.Configuration.Put("MedusaHead", Config.MedusaHead);
        Config.Configuration.Put("MolotovCocktail", Config.MolotovCocktail);
        Config.Configuration.Put("MoltenPickaxe", Config.MoltenPickaxe);
        Config.Configuration.Put("Muramasa", Config.Muramasa);
        Config.Configuration.Put("NebulaArcanum", Config.NebulaArcanum);
        Config.Configuration.Put("NightmarePickaxe", Config.NightmarePickaxe);
        Config.Configuration.Put("NorthPole", Config.NorthPole);
        Config.Configuration.Put("Phantasm", Config.Phantasm);
        Config.Configuration.Put("PhoenixBlaster", Config.PhoenixBlaster);
        Config.Configuration.Put("PoisonedKnife", Config.PoisonedKnife);
        Config.Configuration.Put("PoisonStaff", Config.PoisonStaff);
        Config.Configuration.Put("PossessedHatchet", Config.PossessedHatchet);
        Config.Configuration.Put("RainbowRod", Config.RainbowRod);
        Config.Configuration.Put("Razorpine", Config.Razorpine);
        Config.Configuration.Put("RedsThrow", Config.RedsThrow);
        Config.Configuration.Put("ShadowbeamStaff", Config.ShadowbeamStaff);
        Config.Configuration.Put("SlimeStaff", Config.SlimeStaff);
        Config.Configuration.Put("SpectreHood", Config.SpectreHood);
        Config.Configuration.Put("StaffofRegrowth", Config.StaffofRegrowth);
        Config.Configuration.Put("StarCannon", Config.StarCannon);
        Config.Configuration.Put("StardustDragonStaff", Config.StardustDragonStaff);
        Config.Configuration.Put("Sunfury", Config.Sunfury);
        Config.Configuration.Put("UnholyTrident", Config.UnholyTrident);
        Config.Configuration.Put("ValkyrieYoyo", Config.ValkyrieYoyo);
        Config.Configuration.Put("VampireKnives", Config.VampireKnives);
        Config.Configuration.Put("Vilethorn", Config.Vilethorn);
        Config.Configuration.Put("VortexBeater", Config.VortexBeater);
        Config.Configuration.Save(true);
    }
}