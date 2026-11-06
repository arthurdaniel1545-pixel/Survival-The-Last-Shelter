using System;
using UnityEngine;

namespace SurvivalTheLastShelter.Characters
{
    /// <summary>
    /// Catalog of approved GLB character sources. Paths are relative to the Unity project root.
    /// Runtime loading should use a free glTF importer such as Unity glTFast.
    /// </summary>
    [CreateAssetMenu(fileName = "CharacterModelCatalog", menuName = "Survival/Characters/Model Catalog")]
    public sealed class CharacterModelCatalog : ScriptableObject
    {
        [Serializable]
        public sealed class CharacterModelEntry
        {
            public CharacterSex Sex = CharacterSex.Male;
            public string DisplayName = "Survivor";
            public string RelativeModelPath = "Assets/Art/Characters/Player/SecurityGuard_Male.glb";
            public string[] AnimationClips = Array.Empty<string>();
        }

        [SerializeField] private CharacterModelEntry male = new CharacterModelEntry
        {
            Sex = CharacterSex.Male,
            DisplayName = "Male Survivor",
            RelativeModelPath = "Assets/Art/Characters/Player/SecurityGuard_Male.glb",
            AnimationClips = new[] { "Idle", "Walk", "Run", "Attack", "Hit", "Death", "Special" }
        };

        [SerializeField] private CharacterModelEntry female = new CharacterModelEntry
        {
            Sex = CharacterSex.Female,
            DisplayName = "Female Survivor",
            RelativeModelPath = "Assets/Art/Characters/Player/OfficeLady_Female.glb",
            AnimationClips = new[] { "Idle", "Walk", "Run", "Attack", "Hit", "Death", "Special" }
        };

        public CharacterModelEntry Male => male;
        public CharacterModelEntry Female => female;

        public CharacterModelEntry Get(CharacterSex sex)
        {
            return sex == CharacterSex.Female ? female : male;
        }
    }
}
