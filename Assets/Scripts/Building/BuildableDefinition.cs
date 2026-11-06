using System;
using UnityEngine;
using SurvivalTheLastShelter.Inventory;

namespace SurvivalTheLastShelter.Building
{
    public enum BuildableCategory
    {
        Wall,
        Floor,
        Door,
        Window,
        Roof,
        Fence,
        Tower,
        Barricade,
        Trap
    }

    [Serializable]
    public sealed class BuildCost
    {
        public string ItemId;
        public ItemCategory Category = ItemCategory.Material;
        public int Quantity = 1;
    }

    [CreateAssetMenu(fileName = "Buildable", menuName = "Survival/Building/Buildable")]
    public sealed class BuildableDefinition : ScriptableObject
    {
        [SerializeField] private string buildableId;
        [SerializeField] private string displayName;
        [SerializeField] private BuildableCategory category;
        [SerializeField] private GameObject prefab;
        [SerializeField] private BuildCost[] costs = Array.Empty<BuildCost>();
        [SerializeField] private float maxHealth = 100f;
        [SerializeField] private bool canRotate = true;

        public string BuildableId => buildableId;
        public string DisplayName => displayName;
        public BuildableCategory Category => category;
        public GameObject Prefab => prefab;
        public BuildCost[] Costs => costs;
        public float MaxHealth => maxHealth;
        public bool CanRotate => canRotate;
    }
}
