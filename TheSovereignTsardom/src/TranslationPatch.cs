using System;
using System.Collections.Generic;
using HarmonyLib;
using MGSC;
using UnityEngine;

namespace TheSovereignTsardom
{
    [HarmonyPatch(typeof(ItemBone), "AttachToBone")]
    static class FixRotation
    {
        static void Postfix(ItemBone __instance)
        {
            if (Mathf.Approximately(__instance.Rotation.x, 288))
            {
                __instance.transform.localRotation = Quaternion.Euler(__instance.Rotation);
            }
        }
    }
    
    
    [HarmonyPatch(typeof(Localization))]
    static class TranslationPatch
    {
        [HarmonyPatch("LoadDB"), HarmonyPostfix]
        static void LoadDBPostfix(Dictionary<Localization.Lang, Dictionary<string, string>> ___db)
        {
            Debug.Log("Postfix patch runned");
            foreach (Localization.Lang lang in Enum.GetValues(typeof(Localization.Lang)))
            {
                ___db[lang][$"station.{Plugin.EarthStationId}.shortname"] = "SVY";
                if (lang == Localization.Lang.Russian)
                {
                    // TODO
                }
                else
                {
                    ___db[lang]["item.iom_lasgun.name"] = "Lasgun";
                    ___db[lang]["item.iom_lasgun.shortdesc"] = "Laser Rifle";
                    
                    ___db[lang][$"station.{Plugin.EarthStationId}.name"] = "Svyatitel";
                    ___db[lang][$"station.{Plugin.EarthStationId}.type"] = "Station";
                    
                    ___db[lang][$"item.{Plugin.KriegsmanHelmet}.name"] = "Kriegsman";
                    ___db[lang][$"item.{Plugin.KriegsmanHelmet}.shortdesc"] = "Helmt";
                    ___db[lang][$"item.{Plugin.KriegsmanArmor}.name"] = "Kriegsman";
                    ___db[lang][$"item.{Plugin.KriegsmanArmor}.shortdesc"] = "Armor";
                    ___db[lang][$"item.{Plugin.KriegsmanLeggings}.name"] = "Kriegsman";
                    ___db[lang][$"item.{Plugin.KriegsmanLeggings}.shortdesc"] = "Pants";
                    ___db[lang][$"item.{Plugin.KriegsmanBoots}.name"] = "Kriegsman";
                    ___db[lang][$"item.{Plugin.KriegsmanBoots}.shortdesc"] = "Boots";
                    
                    ___db[lang][$"faction.{Plugin.FactionId}.name"] = "The Sovereign Tsardom";
                    ___db[lang][$"faction.{Plugin.FactionId}.shortdesc"] = "Similar to the WH40k Imperium, but with a sci-fi \"everyone is a clone\" aspect added-in, reinforcing the Imperium's themes of conformity and extinguishing of the individual for the good of the many.\nHowever, must generally be less over-the-top to continue feeling vanilla.\nFaction uses a mixture of ballistic, explosive, frost, and poison weapons and focuses on closer-range combat. It should never use low-caliber ammunition --- this is a way to reflect the over-the-top nature of the Imperium without being out of place in Quasimorph.\nIt also uses superheavy ammo, in fact perhaps acquiring it earlier than Unchained Belt. This should give more variety to a currently underused ammo type.";
                    ___db[lang][$"faction.{Plugin.FactionId}.desc"] = "Following a short but fiery ressurgence of Tsarism during the Great Anarchist Revolution, the then-Royal Family managed to escape the Inner System aboard a commandeered experimental spacecraft, renamed the HIRMS Pobedonosets. \nThe ship's limited cubecentric engines, however, were never designed for such a long, uninterrupted voyage, and would give out before even leaving the Inner System, being reduced to slowly drifting towards the Belt. \nLittle is known of what took place during that time. However, many years afterwards, a fledgling space station would intercept the drifting spacecraft, believing its inhabitants to be long dead, and attempt to salvage it. Not long after, all communications coming from said station would go dark.\nWhen contact would eventually be reestabilished, the Ancap world would be met with an entirely new group, and discover the station's previous skeleton crew had been replaced by a bustling population, all nearly identical to the leaders of its so-called \"Sovereign Tsardom\".\nIn a stroke of fate, the station had been the perfect complement to the Pobedonosets, being able to more than fulfill its cloning facilities' immense energy demands. The ship, which had before been reduced to a few surviving members of the Royal Family, would singlehandedly kickstart the resurgence of an empire.\nOver many generations of sterile clones, however, the Tsardom has degenerated into something entirely unlike what it had been back on Earth: it is now a society of mass-produced clones, separated into castes based on their genetic and phenotypical \"purity\" (i.e.: their resemblance to the original members of the Royal Family), determined by the facilities wherein they are produced, led by the decaying hand of the Eternal Tsar. The cloning facilities of Pobedonosets, meanwhile, remain the marrow of the Tsardom, and the epicenter of their culture and history; as well as the key to their future.";
                }
            }
        }
    }
}