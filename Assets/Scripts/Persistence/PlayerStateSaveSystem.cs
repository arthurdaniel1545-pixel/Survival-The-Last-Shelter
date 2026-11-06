using System;
using System.IO;
using UnityEngine;
using SurvivalTheLastShelter.Inventory;

namespace SurvivalTheLastShelter.Persistence
{
    public static class PlayerStateSaveSystem
    {
        private const string SaveFileName = "player-state.json";

        private static string SavePath => Path.Combine(Application.persistentDataPath, SaveFileName);

        public static bool Save(PlayerStateSaveData state)
        {
            if (state == null) return false;

            try
            {
                File.WriteAllText(SavePath, JsonUtility.ToJson(state, true));
                return true;
            }
            catch (Exception exception)
            {
                Debug.LogError("Falha ao salvar estado do jogador: " + exception.Message);
                return false;
            }
        }

        public static PlayerStateSaveData Load()
        {
            if (!File.Exists(SavePath)) return null;

            try
            {
                PlayerStateSaveData state = JsonUtility.FromJson<PlayerStateSaveData>(File.ReadAllText(SavePath));
                if (state == null) return null;
                if (state.Survival == null) state.Survival = new PlayerSurvivalStats();
                if (state.Inventory == null) state.Inventory = new List<InventoryEntry>();
                if (state.Version <= 0) state.Version = 1;
                return state;
            }
            catch (Exception exception)
            {
                Debug.LogError("Falha ao carregar estado do jogador: " + exception.Message);
                return null;
            }
        }
    }
}
