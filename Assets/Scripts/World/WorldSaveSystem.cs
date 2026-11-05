using System.IO;
using UnityEngine;

namespace SurvivalTheLastShelter.World
{
    public static class WorldSaveSystem
    {
        private const string SaveFileName = "world-save.json";

        private static string SavePath
        {
            get { return Path.Combine(Application.persistentDataPath, SaveFileName); }
        }

        public static void Save(WorldLayout layout)
        {
            if (layout == null || !layout.HasRequiredRegions())
            {
                Debug.LogError("Save cancelado: o mundo precisa ter exatamente 3 cidades e 2 florestas.");
                return;
            }

            string json = JsonUtility.ToJson(layout, true);
            File.WriteAllText(SavePath, json);
        }

        public static WorldLayout Load()
        {
            if (!File.Exists(SavePath)) return null;

            try
            {
                string json = File.ReadAllText(SavePath);
                WorldLayout layout = JsonUtility.FromJson<WorldLayout>(json);
                if (layout == null || !layout.HasRequiredRegions())
                {
                    Debug.LogError("Save inválido: o mundo salvo não contém exatamente 3 cidades e 2 florestas.");
                    return null;
                }
                return layout;
            }
            catch (System.Exception exception)
            {
                Debug.LogError("Não foi possível carregar o mundo salvo: " + exception.Message);
                return null;
            }
        }
    }
}
