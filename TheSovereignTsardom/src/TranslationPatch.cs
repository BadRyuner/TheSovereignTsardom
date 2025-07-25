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
                    ___db[lang][$"faction.{Plugin.FactionId}.shortdesc"] = "Leader: The Eternal Tsar\nHeadquarters: Svyatitel (Burnyi)\n\n\nMonarchist organization, fighting to remake mankind in its image.";
                    ___db[lang][$"faction.{Plugin.FactionId}.desc"] = "Following a short but fiery ressurgence of Tsarism during the Great Anarchist Revolution, the then-Royal Family managed to escape the Inner System aboard a commandeered experimental spacecraft, renamed the HIRMS Pobedonosets. The ship, a top-secret project meant to quickly colonize entire planets with a subservient race of clone labourers produced by its experimental cloning facilities: the most advanced mankind has ever produced. The ship's limited cubecentric engines, however, were never designed for such a long, uninterrupted voyage without the aid of another ship, and would give out before even leaving the Inner System, being reduced to slowly and helplessly drifting towards the Belt. \n\nLittle is known of what took place during that time. However, many years afterwards, a fledgling space station would intercept the drifting spacecraft, believing its inhabitants to be long dead, and attempt to salvage it. Not long in the wake of this fateful decision, all communications coming from said station would go completely dark. Only, when contact would finally be reestabilished, the Ancap world would be met with an entirely new ruling body, and discover the station's previous skeleton crew had been replaced by a bustling population of clones, all nearly identical to the monarchical leader of its so-called \"Sovereign Tsardom\".\n\nIn a stroke of fate, the station had been the perfect complement to the Pobedonosets, for its state-of-the-art reactors and energy storage systems were able to more than fulfill the cloning facilities' immense energy demands. The ship, which had before been reduced to a lone surviving member of the Royal Family, would singlehandedly kickstart the resurgence of an empire.\n\nOver many generations of sterile clones, however, the Tsardom has degenerated into something entirely unlike what it had been back on Earth: it is now a society of mass-produced clones, separated into castes based on their genetic and phenotypical \"purity\" (i.e.: their resemblance to the original members of the Royal Family), determined by the facilities wherein they are produced, led by the decaying hand of the Eternal Tsar. The cloning facilities of Pobedonosets, meanwhile, remain the marrow of the Tsardom, and the epicenter of their culture and history; as well as the key to their future.\n\nHow the Eternal Tsar achieved his immortality is a secret firmly protected by the Tsardom. Among the clone population of the Tsardom, he is hailed as their gene-father, the only pure and \"uncreated\" human, having neither been birthed from a cloning bay nor contaminated by the \"corrupted\" genetics of outsiders. He is a near god-like figure in their strange and unearthly society, although he is forever bound to his life-support throne. To be able to simply glance upon the Tsar is considered the greatest honour that can be achieved, albeit one that comes at a terrible cost: those who have seen the Tsar are not allowed to rejoin the wider clone-society unless they take an oath of silence, consummated by the removal of their tongues, for the true state of their leader is a secret that must never be allowed to leave his great palace.";
                }
            }
        }
    }
}