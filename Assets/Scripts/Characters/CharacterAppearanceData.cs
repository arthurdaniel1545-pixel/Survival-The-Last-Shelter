using System;
using UnityEngine;

namespace SurvivalTheLastShelter.Characters
{
    public enum CharacterSex
    {
        Male,
        Female
    }

    [Serializable]
    public sealed class CharacterAppearanceData
    {
        public CharacterSex Sex = CharacterSex.Male;
        public string HairstyleId = "short_01";
        public Color HairColor = new Color(0.18f, 0.12f, 0.08f);
        public Color SkinColor = new Color(0.72f, 0.48f, 0.34f);
        public Color EyeColor = new Color(0.24f, 0.42f, 0.28f);

        public CharacterAppearanceData Clone()
        {
            return new CharacterAppearanceData
            {
                Sex = Sex,
                HairstyleId = HairstyleId,
                HairColor = HairColor,
                SkinColor = SkinColor,
                EyeColor = EyeColor
            };
        }

        public void CopyFrom(CharacterAppearanceData other)
        {
            if (other == null) return;
            Sex = other.Sex;
            HairstyleId = string.IsNullOrWhiteSpace(other.HairstyleId) ? "short_01" : other.HairstyleId;
            HairColor = other.HairColor;
            SkinColor = other.SkinColor;
            EyeColor = other.EyeColor;
        }
    }
}
