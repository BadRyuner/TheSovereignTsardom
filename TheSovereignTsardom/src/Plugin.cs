using HarmonyLib;
using MGSC;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TheSovereignTsardom
{
    public static partial class Plugin
    {
        public static Logger Logger = new Logger();

        [Hook(ModHookType.BeforeBootstrap)]
        public static void BeforeBootstrap(IModContext context)
        {
            _loadModBundleAsync = AssetBundle.LoadFromFileAsync(Path.Combine(context.ModContentPath, "data.bundle"));
            new Harmony("The Sovereign Tsardom").PatchAll();
        }

        private static AssetBundleCreateRequest _loadModBundleAsync;
        public static AssetBundle ModBundle;
        public const string Id = "tst_tst_";
        
        [Hook(ModHookType.AfterConfigsLoaded)]
        public static void AfterConfig(IModContext context)
        {
            ModBundle = _loadModBundleAsync.assetBundle;
            CreateArmor();
            CreateWeapons();
            CreateFaction();
            Logger.Log("[AfterConfig] Mod Loaded");
        }
        
        public static List<DmgResist> CreateResists(float blunt = 0f, float pierce = 0f, float lacer = 0f, float fire = 0f, float cold = 0f,  float poison = 0f, float shock = 0f, float beam = 0f)
        {
            return [new() { damage = "blunt", resistPercent = blunt },
                new() { damage = "pierce", resistPercent = pierce },
                new() { damage = "lacer", resistPercent = lacer },
                new() { damage = "fire", resistPercent = fire },
                new() { damage = "cold", resistPercent = cold },
                new() { damage = "poison", resistPercent = poison },
                new() { damage = "shock", resistPercent = shock },
                new() { damage = "beam", resistPercent = beam }
            ];
        }
    }
}