using System;
using UnityEngine;

namespace SurvivalTheLastShelter.World
{
    [Serializable]
    public sealed class DemoSpawnPoint
    {
        public string Id = "spawn_player";
        public Vector3 Position = Vector3.zero;
        public Vector3 Forward = Vector3.forward;
    }

    [Serializable]
    public sealed class DemoAreaAssetSet
    {
        public string Category = "Terrain";
        public string[] RelativeAssetPaths = Array.Empty<string>();
    }

    [CreateAssetMenu(fileName = "DemoSurvivalArea", menuName = "Survival/World/Demo Survival Area")]
    public sealed class DemoSurvivalAreaLayout : ScriptableObject
    {
        [Header("World rules")]
        [SerializeField] private int requiredMainCities = 3;
        [SerializeField] private int requiredLargeForests = 2;

        [Header("Demo area")]
        [SerializeField] private string areaName = "Abandoned Suburb Demo";
        [SerializeField] private Vector3 areaSizeMeters = new Vector3(120f, 0f, 120f);

        [Header("Spawns")]
        [SerializeField] private DemoSpawnPoint playerSpawn = new DemoSpawnPoint();
        [SerializeField] private DemoSpawnPoint[] zombieSpawns = Array.Empty<DemoSpawnPoint>();

        [Header("Asset groups")]
        [SerializeField] private DemoAreaAssetSet[] assetGroups = Array.Empty<DemoAreaAssetSet>();

        public int RequiredMainCities => requiredMainCities;
        public int RequiredLargeForests => requiredLargeForests;
        public string AreaName => areaName;
        public Vector3 AreaSizeMeters => areaSizeMeters;
        public DemoSpawnPoint PlayerSpawn => playerSpawn;
        public DemoSpawnPoint[] ZombieSpawns => zombieSpawns;
        public DemoAreaAssetSet[] AssetGroups => assetGroups;
    }
}
