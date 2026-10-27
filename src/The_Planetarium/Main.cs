using HarmonyLib;
using System.Reflection;
using UnityModManagerNet;

namespace The_Planetarium
{
    public static class Main
    {
        public static UnityModManager.ModEntry Mod;
        public static Harmony Harmony;
        public static PlanetariumSettings Settings;

        static bool Load(UnityModManager.ModEntry modEntry)
        {
            Mod = modEntry;

            // Load saved settings from disk (or create defaults the first time)
            Settings = UnityModManager.ModSettings.Load<PlanetariumSettings>(modEntry);

            // Tell UMM which methods draw and save the settings page
            modEntry.OnGUI = OnGUI;
            modEntry.OnSaveGUI = OnSaveGUI;

            Harmony = new Harmony(modEntry.Info.Id);
            Harmony.PatchAll(Assembly.GetExecutingAssembly());

            Mod.Logger.Log("The Planetarium loaded!");
            return true;
        }

        static void OnGUI(UnityModManager.ModEntry modEntry)
        {
            SettingsUI.Draw();
        }

        static void OnSaveGUI(UnityModManager.ModEntry modEntry)
        {
            Settings.Save(modEntry);
        }
    }
}