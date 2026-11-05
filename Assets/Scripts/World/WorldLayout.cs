using System;
using System.Collections.Generic;
using UnityEngine;

namespace SurvivalTheLastShelter.World
{
    [Serializable]
    public sealed class WorldLayout
    {
        public int Seed;
        public List<WorldRegion> Regions = new List<WorldRegion>();

        public int CountOf(WorldRegionType type)
        {
            int count = 0;
            foreach (WorldRegion region in Regions)
            {
                if (region != null && region.Type == type) count++;
            }
            return count;
        }

        public bool HasRequiredRegions()
        {
            return CountOf(WorldRegionType.City) == 3 && CountOf(WorldRegionType.Forest) == 2;
        }

        public static WorldLayout Generate(int seed, int extraPointCount)
        {
            var random = new System.Random(seed);
            var layout = new WorldLayout { Seed = seed };

            // These five regions are mandatory and are never part of random generation.
            layout.Regions.Add(new WorldRegion("city_01", "Cidade Abandonada", WorldRegionType.City, new Vector2(-600f, -250f)));
            layout.Regions.Add(new WorldRegion("city_02", "Distrito Industrial", WorldRegionType.City, new Vector2(550f, -350f)));
            layout.Regions.Add(new WorldRegion("city_03", "Centro em Ruínas", WorldRegionType.City, new Vector2(0f, 650f)));
            layout.Regions.Add(new WorldRegion("forest_01", "Floresta do Norte", WorldRegionType.Forest, new Vector2(-650f, 550f)));
            layout.Regions.Add(new WorldRegion("forest_02", "Floresta do Sul", WorldRegionType.Forest, new Vector2(650f, 550f)));

            string[] extraNames = { "Acampamento", "Posto Militar", "Fazenda Abandonada", "Estação de Rádio", "Pedreira", "Bunker", "Vila em Ruínas", "Depósito" };
            int safeExtraCount = Mathf.Clamp(extraPointCount, 0, 100);
            for (int i = 0; i < safeExtraCount; i++)
            {
                float x = (float)(random.NextDouble() * 1800.0 - 900.0);
                float y = (float)(random.NextDouble() * 1800.0 - 900.0);
                string name = extraNames[random.Next(extraNames.Length)];
                layout.Regions.Add(new WorldRegion("poi_" + (i + 1).ToString("D3"), name, WorldRegionType.PointOfInterest, new Vector2(x, y)));
            }

            return layout;
        }
    }
}
