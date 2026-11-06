using System;
using System.IO;
using UnityEngine;
using SurvivalTheLastShelter.Characters;
using SurvivalTheLastShelter.Equipment;

namespace SurvivalTheLastShelter.Persistence
{
    [Serializable]
    public sealed class PlayerProfileData
    {
        public int Version = 1;
        public CharacterAppearanceData Appearance = new CharacterAppearanceData();
        public CharacterEquipmentLoadout Equipment = new CharacterEquipmentLoadout();

        public static PlayerProfileData CreateNew()
        {
            var profile = new PlayerProfileData();
            profile.Equipment.EquipStarterItem(EquipmentSlot.UpperBody, "basic_shirt");
            profile.Equipment.EquipStarterItem(EquipmentSlot.LowerBody, "basic_trousers");
            profile.Equipment.EquipStarterItem(EquipmentSlot.Footwear, "basic_shoes");
            return profile;
        }
    }

    public static class PlayerProfileSaveSystem
    {
        private const string SaveFileName = "player-profile.json";

        private static string SavePath =>
            Path.Combine(Application.persistentDataPath, SaveFileName);

        public static bool Save(PlayerProfileData profile)
        {
            if (profile == null || profile.Appearance == null || profile.Equipment == null)
                return false;

            try
            {
                File.WriteAllText(SavePath, JsonUtility.ToJson(profile, true));
                return true;
            }
            catch (Exception exception)
            {
                Debug.LogError("Falha ao salvar perfil do jogador: " + exception.Message);
                return false;
            }
        }

        public static PlayerProfileData Load()
        {
            if (!File.Exists(SavePath)) return null;

            try
            {
                PlayerProfileData profile = JsonUtility.FromJson<PlayerProfileData>(File.ReadAllText(SavePath));
                if (profile == null) return null;
                if (profile.Appearance == null) profile.Appearance = new CharacterAppearanceData();
                if (profile.Equipment == null) profile.Equipment = new CharacterEquipmentLoadout();
                if (profile.Version <= 0) profile.Version = 1;
                return profile;
            }
            catch (Exception exception)
            {
                Debug.LogError("Falha ao carregar perfil do jogador: " + exception.Message);
                return null;
            }
        }
    }
}
