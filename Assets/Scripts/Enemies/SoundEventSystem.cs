using System;
using System.Collections.Generic;
using UnityEngine;

namespace SurvivalTheLastShelter.Enemies
{
    public enum SoundType
    {
        Footstep,
        Run,
        Gunshot,
        Construction,
        Impact
    }

    [Serializable]
    public sealed class SoundEvent
    {
        public Vector3 Position;
        public float Intensity = 1f;
        public SoundType Type = SoundType.Footstep;
        public GameObject Source;
    }

    public static class SoundEventSystem
    {
        private static readonly List<SoundEvent> _events = new List<SoundEvent>();

        public static void Emit(SoundEvent soundEvent)
        {
            if (soundEvent == null) return;
            _events.Add(soundEvent);
        }

        public static IReadOnlyList<SoundEvent> Events => _events;

        public static void ClearFrame()
        {
            _events.Clear();
        }
    }
}
