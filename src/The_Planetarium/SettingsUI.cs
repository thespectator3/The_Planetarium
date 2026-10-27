using UnityEngine;

namespace The_Planetarium
{
    public static class SettingsUI
    {
        private static readonly string[] Tabs =
        {
            "General", "Planet Colors", "Key Viewer", "UI", "Levels"
        };

        public static void Draw()
        {
            var s = Main.Settings;

            // Row of tab buttons at the top
            s.SelectedTab = GUILayout.Toolbar(s.SelectedTab, Tabs);
            GUILayout.Space(10);

            switch (s.SelectedTab)
            {
                case 0: DrawGeneral(s); break;
                case 1: DrawPlaceholder("Planet color options will go here."); break;
                case 2: DrawPlaceholder("Key viewer options will go here."); break;
                case 3: DrawPlaceholder("UI options will go here."); break;
                case 4: DrawPlaceholder("Level library options will go here."); break;
            }
        }

        private static void DrawGeneral(PlanetariumSettings s)
        {
            s.ExampleToggle = GUILayout.Toggle(s.ExampleToggle, "Example toggle");

            GUILayout.BeginHorizontal();
            GUILayout.Label("Example slider: " + s.ExampleSlider.ToString("0.00"), GUILayout.Width(200));
            s.ExampleSlider = GUILayout.HorizontalSlider(s.ExampleSlider, 0f, 2f, GUILayout.Width(250));
            GUILayout.EndHorizontal();
        }

        private static void DrawPlaceholder(string text)
        {
            GUILayout.Label(text);
        }
    }
}