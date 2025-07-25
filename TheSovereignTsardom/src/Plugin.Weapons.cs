using System.Collections.Generic;
using MGSC;

namespace TheSovereignTsardom;

public static partial class Plugin
{
    public const string ComitatusId = FactionId + "Comitatus";
    public const string FidelityId = FactionId + "Fidelity";
    public const string FealtyId = FactionId + "Fealty";
    public const string VassalId = FactionId + "Vassal";
    public const string FjordId = FactionId + "Fjord";
    public const string TundraId = FactionId + "Tundra";
    public const string PermafrostId = FactionId + "Permafrost";
    public const string ChainswordId = FactionId + "Chainsword";
    public const string AconiteId = FactionId + "Aconite";
    public const string OleanderId = FactionId + "Oleander";
    
    static void CreateWeapons()
    {
        CreateComitatus();
        CreateFidelity();
        CreateFealty();
        CreateVassal();
        CreateFjord();
        CreateTundra();
        CreatePermafrost();
        CreateChainsword();
        CreateAconite();
        CreateOleander();
    }

    private static readonly List<string> FirearmsWeapon = ["plastic", "weapon_parts"];
    private static readonly List<string> TechWeapon = ["microelectronics_parts", "capacitor_parts"];
    
    static void CreateComitatus()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("BolterHmgDesc");
        var weap = new WeaponRecord
        {
            Id = ComitatusId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 9,
            Price = 3000,
            Weight = 6,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 30,
                maxDmg = 60,
                critDmg = 1.8f,
                critChance = 0
            },
            Range = 4,
            MagazineCapacity = 40,
            ReloadDuration = 7,
            DefaultAmmoId = "HeavyBasicAmmo",
            RequiredAmmo = "SuperHeavy",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["basic_pistol_burst"],
            MaxDurability = 250,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = FirearmsWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Machinegun,
            WeaponSubClass = WeaponSubClass.Firearm,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 1,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(ComitatusId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(ComitatusId, desc);
    }
    
    static void CreateFidelity()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("BolterMediumDesc");
        var weap = new WeaponRecord
        {
            Id = FidelityId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 6,
            Price = 800,
            Weight = 5,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 25,
                maxDmg = 50,
                critDmg = 2f,
                critChance = 0
            },
            Range = 4,
            MagazineCapacity = 6,
            ReloadDuration = 3,
            DefaultAmmoId = "HeavyBasicAmmo",
            RequiredAmmo = "SuperHeavy",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["basic_pistol_single", "basic_pistol_burst"],
            MaxDurability = 75,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = FirearmsWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Pistol,
            WeaponSubClass = WeaponSubClass.Firearm,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 1,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(FidelityId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(FidelityId, desc);
    }
    
    static void CreateFealty()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("BolterLightDesc");
        var weap = new WeaponRecord
        {
            Id = FealtyId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 3,
            Price = 400,
            Weight = 3.5f,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 20,
                maxDmg = 40,
                critDmg = 2f,
                critChance = 0
            },
            Range = 3,
            MagazineCapacity = 4,
            ReloadDuration = 3,
            DefaultAmmoId = "HeavyBasicAmmo",
            RequiredAmmo = "SuperHeavy",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["basic_pistol_single"],
            MaxDurability = 60,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = FirearmsWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Pistol,
            WeaponSubClass = WeaponSubClass.Firearm,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 1,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(FealtyId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(FealtyId, desc);
    }
    
    static void CreateVassal()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("TsarLmgDesc");
        var weap = new WeaponRecord
        {
            Id = VassalId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 2,
            Price = 300,
            Weight = 3.6f,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 10,
                maxDmg = 28,
                critDmg = 1.8f,
                critChance = 0
            },
            Range = 3,
            MagazineCapacity = 28,
            ReloadDuration = 4,
            DefaultAmmoId = "rifle_basic_ammo",
            RequiredAmmo = "Heavy",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["basic_rifle_burst"],
            MaxDurability = 60,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = FirearmsWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Machinegun,
            WeaponSubClass = WeaponSubClass.Firearm,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 1,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(VassalId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(VassalId, desc);
    }
    
    static void CreateFjord()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("TsarFrostPistolDesc");
        var weap = new WeaponRecord
        {
            Id = FjordId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 4,
            Price = 800,
            Weight = 2.1f,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 24,
                maxDmg = 36,
                critDmg = 1.7f,
                critChance = 0
            },
            Range = 5,
            MagazineCapacity = 7,
            ReloadDuration = 3,
            DefaultAmmoId = "battery_basic_ammo",
            RequiredAmmo = "BatteryCells",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["basic_pistol_single"],
            MaxDurability = 60,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = TechWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Pistol,
            WeaponSubClass = WeaponSubClass.Coldgun,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 1,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(FjordId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(FjordId, desc);
    }
    
    static void CreateTundra()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("TsarFrostShotgunDesc");
        var weap = new WeaponRecord
        {
            Id = TundraId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 7,
            Price = 1200,
            Weight = 3f,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 8*4,
                maxDmg = 12*4,
                critDmg = 1.7f,
                critChance = 0
            },
            Range = 4,
            MagazineCapacity = 5,
            ReloadDuration = 3,
            DefaultAmmoId = "battery_basic_ammo",
            RequiredAmmo = "BatteryCells",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["basic_energy_shotgun_auto"],
            MaxDurability = 80,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = TechWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Pistol,
            WeaponSubClass = WeaponSubClass.Coldgun,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 1,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(TundraId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(TundraId, desc);
    }
    
    static void CreatePermafrost()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("TsarFrostRifleDesc");
        var weap = new WeaponRecord
        {
            Id = PermafrostId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 10,
            Price = 3600,
            Weight = 3.6f,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 24,
                maxDmg = 36,
                critDmg = 1.7f,
                critChance = 0
            },
            Range = 7,
            MagazineCapacity = 12,
            ReloadDuration = 4,
            DefaultAmmoId = "battery_basic_ammo",
            RequiredAmmo = "BatteryCells",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["basic_energy_shotgun_auto"], // TODO add 3 shots
            MaxDurability = 120,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = TechWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Pistol,
            WeaponSubClass = WeaponSubClass.Coldgun,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 0.7f,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(PermafrostId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(PermafrostId, desc);
    }
    
    static void CreateChainsword()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("TsarChainSwordDesc");
        var weap = new WeaponRecord
        {
            Id = ChainswordId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 6,
            Price = 1200,
            Weight = 3.1f,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 30,
                maxDmg = 40,
                critDmg = 1.8f,
                critChance = 0
            },
            Range = 1,
            MagazineCapacity = 12,
            ReloadDuration = 2,
            DefaultAmmoId = "gas_ammo",
            RequiredAmmo = "Gas",
            OverrideAmmo = ["implicted_sawblade", "implicted_sawblade_long"],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = true,
            Firemodes = ["power_double_slash", "power_strong_slash"],
            MaxDurability = 90,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = FirearmsWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Chainsaw,
            WeaponSubClass = WeaponSubClass.Default,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 1,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(ComitatusId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(ComitatusId, desc);
    }
    
    static void CreateAconite()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("TsarPoisionGunLightDesc");
        var weap = new WeaponRecord
        {
            Id = AconiteId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 5,
            Price = 1500,
            Weight = 3.5f,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 1,
                maxDmg = 1,
                critDmg = 1.7f,
                critChance = 0
            },
            Range = 4,
            MagazineCapacity = 6,
            ReloadDuration = 6,
            DefaultAmmoId = "toxic_ammo",
            RequiredAmmo = "Toxic",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["implicted_toxicthrower"],
            MaxDurability = 120,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = TechWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Flamethrower,
            WeaponSubClass = WeaponSubClass.Toxic,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 0.7f,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(AconiteId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(AconiteId, desc);
    }
    
    static void CreateOleander()
    {
        var desc = ModBundle.LoadAsset<WeaponDescriptor>("TsarPoisionGunHeavyDesc");
        var weap = new WeaponRecord
        {
            Id = OleanderId,
            ContentDescriptor = desc,
            Categories = [FactionId],
            TechLevel = 8,
            Price = 2400,
            Weight = 6.5f,
            InventoryWidthSize = 2,
            ItemClass = ItemClass.Weapon,
            Damage = new DmgInfo()
            {
                minDmg = 2,
                maxDmg = 2,
                critDmg = 1.7f,
                critChance = 0
            },
            Range = 4,
            MagazineCapacity = 5,
            ReloadDuration = 7,
            DefaultAmmoId = "toxic_ammo",
            RequiredAmmo = "Toxic",
            OverrideAmmo = [],
            GetMeleeDamageFromCreature = false,
            MinRandomAmmoCount = 0,
            DurabilityLossOnThrow = 0,
            ThrowRange = 0,
            MeleeCanAmputate = false,
            Firemodes = ["implicted_toxicthrower"],
            MaxDurability = 120,
            MinDurabilityAfterRepair = 0,
            Unbreakable = false,
            RepairItemIds = TechWeapon,
            IsImplicit = false,
            IsMelee = false,
            WeaponClass = WeaponClass.Flamethrower,
            WeaponSubClass = WeaponSubClass.Toxic,
            DefaultGrenadeId = string.Empty,
            AllowedGrenadeIds = [],
            BonusAccuracy = 0,
            BonusScatterAngle = 0,
            FovLookAngleMult = 0.7f,
            DotWoundsDmgBonus = 0,
            FractureWoundDmgBonus = 0,
        };
        Data.Items.AddRecord(OleanderId, weap);
        Data.Descriptors["rangeweapons"].AddDescriptor(OleanderId, desc);
    }
}