using System.Collections.Generic;
using MGSC;
using UnityEngine;

namespace TheSovereignTsardom;

public static partial class Plugin
{
    public const string Helmet = "Helmet";
    public const string Armor = "Armor";
    public const string Leggings = "Leggings";
    public const string Boots = "Boots";
    
    public const string StreletsHelmet = FactionId + "Strelets" + Helmet;
    
    public const string KriegsmanId = FactionId + "Kriegsman";
    public const string KriegsmanHelmet = KriegsmanId + Helmet;
    public const string KriegsmanArmor = KriegsmanId + Armor;
    public const string KriegsmanLeggings = KriegsmanId + Leggings;
    public const string KriegsmanBoots = KriegsmanId + Boots;
    
    public const string VoenkomId = FactionId + "Voenkom";
    public const string VoenkomHelmet = VoenkomId + Helmet;
    public const string VoenkomArmor = VoenkomId + Armor;
    public const string VoenkomLeggings = VoenkomId + Leggings;
    public const string VoenkomBoots = VoenkomId + Boots;
    
    public const string SvitaId = FactionId + "Svita";
    public const string SvitaHelmet = SvitaId + Helmet;
    public const string SvitaArmor = SvitaId + Armor;
    public const string SvitaLeggings = SvitaId + Leggings;
    public const string SvitaBoots = SvitaId + Boots;

    private static List<ArmorArchType> HumanArmorArcheTypes;
    
    static void CreateArmor()
    {
        HumanArmorArcheTypes = ((ActorDescriptor)Data.Actors.GetRecord("human_male").ContentDescriptor).ArmorArchTypes;
        CreateStrelets();
        CreateKriegsman();
        CreateVoenkom();
        CreateSvita();
        Logger.Log(StreletsHelmet);
        Logger.Log(VoenkomHelmet);
        Logger.Log(VoenkomArmor);
        Logger.Log(VoenkomLeggings);
        Logger.Log(VoenkomBoots);
        Logger.Log(SvitaHelmet);
        Logger.Log(SvitaArmor);
        Logger.Log(SvitaLeggings);
        Logger.Log(SvitaBoots);
    }

    private static readonly List<string> MetalArmor = ["plastic", "rusty_plates", "armor_plates"];
    private static readonly List<string> SintCloth = ["rags"];
    private static readonly List<string> AramArmor = ["rags", "rusty_plates", "armor_plates"];
    private static readonly List<string> CeramiteShell = ["rags", "rubber", "armor_plates"];
    
    static void CreateStrelets()
    {
        var streletsHelmetDesc = ModBundle.LoadAsset<HelmetDescriptor>("StreletsHelmet");;
        var streletsHelmet = new HelmetRecord
        {
            Id = StreletsHelmet,
            ContentDescriptor = streletsHelmetDesc,
            Categories = [FactionId],
            TechLevel = 1,
            Price = 80,
            Weight = 1.6f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Armor,
            MaxDurability = 60,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = MetalArmor,
            ResistSheet = CreateResists(2f, 6f, poison: 4f),
            ArmorClass = ArmorClass.LightArmor,
            ArmorSubClass = ArmorSubClass.Default,
            HideHair = true,
        };
        Data.Items.AddRecord(StreletsHelmet, streletsHelmet);
        Data.Descriptors["helmets"].AddDescriptor(StreletsHelmet, streletsHelmetDesc);
        
        var helmetPrefab = ModBundle.LoadAsset<GameObject>("TsarHelmet0Prefab");
        helmetPrefab.name = "Head";
        HumanArmorArcheTypes.Add(new()
        {
            ArmorType = "TsarHelmet0",
            Prefabs = [helmetPrefab]
        });
    }
    
    static void CreateKriegsman()
    {
        var kriegsmanBootsDesc = ModBundle.LoadAsset<BootsDescriptor>("KriegsmanBoots");;
        var kriegsmanBoots = new BootsRecord
        {
            Id = KriegsmanBoots,
            ContentDescriptor = kriegsmanBootsDesc,
            Categories = [FactionId],
            TechLevel = 3,
            Price = 280,
            Weight = 2.6f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Boots,
            MaxDurability = 70,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = SintCloth,
            ResistSheet = CreateResists(5f, 8f, poison: 8f, cold: 5f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(KriegsmanBoots, kriegsmanBoots);
        Data.Descriptors["boots"].AddDescriptor(KriegsmanBoots, kriegsmanBootsDesc);
            
        var kriegsmanLeggingsDesc = ModBundle.LoadAsset<LeggingsDescriptor>("KriegsmanLeggings");
        var kriegsmanLeggings = new LeggingsRecord
        {
            Id = KriegsmanLeggings,
            ContentDescriptor = kriegsmanLeggingsDesc,
            Categories = [FactionId],
            TechLevel = 3,
            Price = 360,
            Weight = 3.2f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Leggings,
            MaxDurability = 100,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = SintCloth,
            ResistSheet = CreateResists(7f, 10f, poison: 10f, cold: 7f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(KriegsmanLeggings, kriegsmanLeggings);
        Data.Descriptors["leggings"].AddDescriptor(KriegsmanLeggings, kriegsmanLeggingsDesc);

        var kriegsmanArmorDesc = ModBundle.LoadAsset<ArmorDescriptor>("KriegsmanArmor");;
        var kriegsmanArmor = new ArmorRecord()
        {
            Id = KriegsmanArmor,
            ContentDescriptor = kriegsmanArmorDesc,
            Categories = [FactionId],
            TechLevel = 3,
            Price = 400,
            Weight = 3.6f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Armor,
            MaxDurability = 120,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = SintCloth,
            ResistSheet = CreateResists(8f, 11f, poison: 11f, cold: 8f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(KriegsmanArmor, kriegsmanArmor);
        Data.Descriptors["armors"].AddDescriptor(KriegsmanArmor, kriegsmanArmorDesc); 
            
        var kriegsmanHelmetDesc = ModBundle.LoadAsset<HelmetDescriptor>("KriegsmanHelmet");;
        var kriegsmanHelmet = new HelmetRecord
        {
            Id = KriegsmanHelmet,
            ContentDescriptor = kriegsmanHelmetDesc,
            Categories = [FactionId],
            TechLevel = 3,
            Price = 320,
            Weight = 3f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Armor,
            MaxDurability = 80,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = MetalArmor,
            ResistSheet = CreateResists(4f, 8f, cold: 2f, poison: 12f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
            HideHair = true,
        };
        Data.Items.AddRecord(KriegsmanHelmet, kriegsmanHelmet);
        Data.Descriptors["helmets"].AddDescriptor(KriegsmanHelmet, kriegsmanHelmetDesc);

        // register prefab
        var helmetPrefab = ModBundle.LoadAsset<GameObject>("TsarHelmet1Prefab");
        helmetPrefab.name = "Head";
        HumanArmorArcheTypes.Add(new()
        {
            ArmorType = "TsarHelmet1",
            Prefabs = [helmetPrefab]
        });
    }
    
    static void CreateVoenkom()
    {
        var voenkomBootsDesc = ModBundle.LoadAsset<BootsDescriptor>("VoenkomBoots");;
        var voenkomBoots = new BootsRecord
        {
            Id = VoenkomBoots,
            ContentDescriptor = voenkomBootsDesc,
            Categories = [FactionId],
            TechLevel = 5,
            Price = 500,
            Weight = 3.8f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Boots,
            MaxDurability = 140,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = AramArmor,
            ResistSheet = CreateResists(6f, 8f, poison: 8f, cold: 6f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(VoenkomBoots, voenkomBoots);
        Data.Descriptors["boots"].AddDescriptor(VoenkomBoots, voenkomBootsDesc);
            
        var voenkomLeggingsDesc = ModBundle.LoadAsset<LeggingsDescriptor>("VoenkomLeggings");
        var voenkomLeggings = new LeggingsRecord
        {
            Id = VoenkomLeggings,
            ContentDescriptor = voenkomLeggingsDesc,
            Categories = [FactionId],
            TechLevel = 5,
            Price = 700,
            Weight = 4f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Leggings,
            MaxDurability = 200,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = AramArmor,
            ResistSheet = CreateResists(10f, 12f, poison: 12f, cold: 10f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(VoenkomLeggings, voenkomLeggings);
        Data.Descriptors["leggings"].AddDescriptor(VoenkomLeggings, voenkomLeggingsDesc);

        var voenkomArmorDesc = ModBundle.LoadAsset<ArmorDescriptor>("VoenkomArmor");;
        var voenkomArmor = new ArmorRecord()
        {
            Id = VoenkomArmor,
            ContentDescriptor = voenkomArmorDesc,
            Categories = [FactionId],
            TechLevel = 5,
            Price = 800,
            Weight = 4.4f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Armor,
            MaxDurability = 200,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = AramArmor,
            ResistSheet = CreateResists(10f, 12f, poison: 12f, cold: 12f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(VoenkomArmor, voenkomArmor);
        Data.Descriptors["armors"].AddDescriptor(VoenkomArmor, voenkomArmorDesc); 
            
        var voenkomHelmetDesc = ModBundle.LoadAsset<HelmetDescriptor>("VoenkomHelmet");;
        var voenkomHelmet = new HelmetRecord
        {
            Id = VoenkomHelmet,
            ContentDescriptor = voenkomHelmetDesc,
            Categories = [FactionId],
            TechLevel = 5,
            Price = 600,
            Weight = 3.2f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Armor,
            MaxDurability = 140,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = AramArmor,
            ResistSheet = CreateResists(6f, 10f, cold: 4f, poison: 12f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
            HideHair = true,
        };
        Data.Items.AddRecord(VoenkomHelmet, voenkomHelmet);
        Data.Descriptors["helmets"].AddDescriptor(VoenkomHelmet, voenkomHelmetDesc);

        // register prefab
        var helmetPrefab = ModBundle.LoadAsset<GameObject>("TsarHelmet2Prefab");
        helmetPrefab.name = "Head";
        HumanArmorArcheTypes.Add(new()
        {
            ArmorType = "TsarHelmet2",
            Prefabs = [helmetPrefab]
        });
    }
    
    static void CreateSvita()
    {
        var svitaBootsDesc = ModBundle.LoadAsset<BootsDescriptor>("SvitaBoots");;
        var svitaBoots = new BootsRecord
        {
            Id = SvitaBoots,
            ContentDescriptor = svitaBootsDesc,
            Categories = [FactionId],
            TechLevel = 7,
            Price = 280,
            Weight = 2.6f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Boots,
            MaxDurability = 70,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = CeramiteShell,
            ResistSheet = CreateResists(5f, 8f, poison: 8f, cold: 5f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(SvitaBoots, svitaBoots);
        Data.Descriptors["boots"].AddDescriptor(SvitaBoots, svitaBootsDesc);
            
        var svitaLeggingsDesc = ModBundle.LoadAsset<LeggingsDescriptor>("SvitaLeggings");
        var svitaLeggings = new LeggingsRecord
        {
            Id = SvitaLeggings,
            ContentDescriptor = svitaLeggingsDesc,
            Categories = [FactionId],
            TechLevel = 7,
            Price = 360,
            Weight = 3.2f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Leggings,
            MaxDurability = 100,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = CeramiteShell,
            ResistSheet = CreateResists(7f, 10f, poison: 10f, cold: 7f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(SvitaLeggings, svitaLeggings);
        Data.Descriptors["leggings"].AddDescriptor(SvitaLeggings, svitaLeggingsDesc);

        var svitaArmorDesc = ModBundle.LoadAsset<ArmorDescriptor>("SvitaArmor");;
        var svitaArmor = new ArmorRecord()
        {
            Id = SvitaArmor,
            ContentDescriptor = svitaArmorDesc,
            Categories = [FactionId],
            TechLevel = 7,
            Price = 400,
            Weight = 3.6f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Armor,
            MaxDurability = 120,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = CeramiteShell,
            ResistSheet = CreateResists(8f, 11f, poison: 11f, cold: 8f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
        };
        Data.Items.AddRecord(SvitaArmor, svitaArmor);
        Data.Descriptors["armors"].AddDescriptor(SvitaArmor, svitaArmorDesc); 
            
        var svitaHelmetDesc = ModBundle.LoadAsset<HelmetDescriptor>("SvitaHelmet");;
        var svitaHelmet = new HelmetRecord
        {
            Id = SvitaHelmet,
            ContentDescriptor = svitaHelmetDesc,
            Categories = [FactionId],
            TechLevel = 7,
            Price = 320,
            Weight = 3f,
            InventoryWidthSize = 1,
            ItemClass = ItemClass.Armor,
            MaxDurability = 80,
            MinDurabilityAfterRepair = 0,
            RepairItemIds = CeramiteShell,
            ResistSheet = CreateResists(4f, 8f, cold: 2f, poison: 12f),
            ArmorClass = ArmorClass.MediumArmor,
            ArmorSubClass = ArmorSubClass.Default,
            HideHair = true,
        };
        Data.Items.AddRecord(SvitaHelmet, svitaHelmet);
        Data.Descriptors["helmets"].AddDescriptor(SvitaHelmet, svitaHelmetDesc);

        // register prefab
        var helmetPrefab = ModBundle.LoadAsset<GameObject>("TsarHelmet3Prefab");
        helmetPrefab.name = "Head";
        HumanArmorArcheTypes.Add(new()
        {
            ArmorType = "TsarHelmet3",
            Prefabs = [helmetPrefab]
        });
    }
}