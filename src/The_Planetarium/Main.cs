using HarmonyLib;
using System.Reflection;
using UnityModManagerNet;

namespace The_Planetarium
{
    public static class Main
    {
        public static UnityModManager.ModEntry Mod;
        public static Harmony Harmony;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            Mod = modEntry;
            Mod.Logger.Log("The Planetarium loaded!");
            Harmony = new Harmony(modEntry.Info.Id);
            Harmony.PatchAll(Assembly.GetExecutingAssembly());
            return true;
        }
    }
}