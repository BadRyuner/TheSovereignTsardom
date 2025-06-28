using System.Collections.Generic;
using MGSC;

namespace TheSovereignTsardom
{
    public static partial class Plugin
    {
        public const string FactionId = Id + "faction";

        public const string EarthStationId = Id + "Svyatitel";
        
        static void CreateFaction()
        {
            var portrait = ModBundle.LoadAsset<PortraitDescriptor>("Portrait");
            Data.Portraits.AddRecord("faction_" + FactionId, new()
            {
                Id = "faction_" + FactionId, 
                ContentDescriptor = portrait
            });
            Data.Descriptors["portraits"].AddDescriptor("faction_" + FactionId, portrait);
            
            var faction = ModBundle.LoadAsset<FactionDescriptor>("Faction");
            Data.Factions.AddRecord(FactionId, new()
            {
                Id = FactionId,
                ContentDescriptor = faction,
                Enabled = true,
                InitialPower = 1900,
                InitialTechLevel = 1,
                InitialPlayerReputation = 0,
                FactionType = FactionType.CivilRes,
                AllianceType = "Resistance",
                SpawnMissionChance = 0.1f,
                Strategies = [ new(1f, FactionStrategy.Expansion) ],
                StrategyDurationMinHours = 672,
                StrategyDurationMaxHours = 1344,
                GuardCreatureId = "elite_sbn",
                AgentCreatureId = "civilian",
                MinQmorphosWhenVictims = 0,
                UseGeneralRewards = true,
                PortraitsByStrategy = false,
                ItemDropCategories = [ FactionId ]
            });
            Data.Descriptors["factions"].AddDescriptor(FactionId, faction);
            
            var earthStationDummy = Data.Stations.GetRecord("Paragon");
            Data.Stations.AddRecord(EarthStationId, new StationRecord
            {
                Id = EarthStationId,
                ContentDescriptor = earthStationDummy.ContentDescriptor,
                SpaceObjectId = "earth",
                InitialOwnerFactionId = FactionId,
                Power = 0,
                PowerGain = 2,
                TechLevelGain = 3,
                UncapturableByDefault = true,
                CaptureChance = 0.2f,
                MissionTemplateId = "orbit1",
                MissionNameTemplateId = "mercurySurfaceLevels",
                BramfaturaId = "Earth",
                StationType = "SpaceStation",
                SpaceObjectItemDropPercent = 0.1f,
                InitialPopulation = 22314,
                MaxPopulation = 60840,
            });
            
            Data.StationBarter.AddRecord(EarthStationId, new StationBarterRecord
            {
                Id = EarthStationId,
                ContentDescriptor = null,
                CorpProduceItems = [],
                CorpAdditionalConsumeItems = [],
                CivResProduceItems = [],
                CivResAdditionalConsumeItems = [],
                QuasiProduceItems = [],
                QuasiAdditionalConsumeItems = [],
                PiratesProduceItems = [],
                PiratesAdditionalConsumeItems = [],
            });
            
            
            var dropDict = new Dictionary<int, List<ContentDropRecord>>();
            dropDict.Add(0, []);
            dropDict.Add(1, []);
            dropDict.Add(2, []);
            dropDict.Add(3, []);
            dropDict.Add(4, []);
            dropDict.Add(5, []);
            dropDict.Add(6, []);
            dropDict.Add(7, []);
            dropDict.Add(8, []);
            dropDict.Add(9, []);
            dropDict.Add(10, []);
            Data.FactionDrop._recordsByFactions.Add($"{FactionId}_rewardEquipment", dropDict);
            
            dropDict = new();
            dropDict.Add(0, []);
            dropDict.Add(1, []);
            dropDict.Add(2, []);
            dropDict.Add(3, []);
            dropDict.Add(4, []);
            dropDict.Add(5, []);
            dropDict.Add(6, []);
            dropDict.Add(7, []);
            dropDict.Add(8, []);
            dropDict.Add(9, []);
            dropDict.Add(10, []);
            Data.FactionDrop._recordsByFactions.Add($"{FactionId}_rewardConsumables", dropDict);
            
            dropDict = new();
            dropDict.Add(0, []);
            dropDict.Add(1, []);
            dropDict.Add(2, []);
            dropDict.Add(3, []);
            dropDict.Add(4, []);
            dropDict.Add(5, []);
            dropDict.Add(6, []);
            dropDict.Add(7, []);
            dropDict.Add(8, []);
            dropDict.Add(9, []);
            dropDict.Add(10, []);
            Data.FactionDrop._recordsByFactions.Add($"{FactionId}_rewardChips", dropDict);
        }
    }
}