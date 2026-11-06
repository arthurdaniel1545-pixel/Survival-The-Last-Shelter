using System;
using UnityEngine;

namespace SurvivalTheLastShelter.Characters
{
    /// <summary>
    /// Clip-name mapping for a character model. Clip names must match the GLB animation names.
    /// </summary>
    [Serializable]
    public sealed class CharacterAnimationSet
    {
        public string Idle = "Idle";
        public string Walk = "Walk";
        public string Run = "Run";
        public string Attack = "Attack";
        public string Hit = "Hit";
        public string Death = "Death";
    }
}
