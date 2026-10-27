using System;
using UnityModManagerNet;

namespace The_Planetarium
{
    [Serializable]
    public class PlanetariumSettings : UnityModManager.ModSettings
    {
        // Which tab is open (remembered between sessions)
        public int SelectedTab = 0;

        // Example values
        public bool ExampleToggle = true;
        public float ExampleSlider = 1f;

        public override void Save(UnityModManager.ModEntry modEntry)
        {
            Save(this, modEntry);
        }
    }
}