using System;
using UnityEngine;

namespace SurvivalTheLastShelter.World
{
    public enum WorldRegionType
    {
        City,
        Forest,
        PointOfInterest
    }

    [Serializable]
    public sealed class WorldRegion
    {
        public string Id;
        public string DisplayName;
        public WorldRegionType Type;
        public Vector2 Position;

        public WorldRegion(string id, string displayName, WorldRegionType type, Vector2 position)
        {
            Id = id;
            DisplayName = displayName;
            Type = type;
            Position = position;
        }
    }
}
