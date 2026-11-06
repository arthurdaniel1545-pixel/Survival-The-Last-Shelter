using UnityEngine;

namespace SurvivalTheLastShelter.Equipment
{
    public enum EquipmentSlot
    {
        Head,
        Face,
        UpperBody,
        LowerBody,
        Footwear,
        Backpack,
        Utility
    }

    [CreateAssetMenu(fileName = "WearableItem", menuName = "Survival/Equipment/Wearable Item")]
    public sealed class WearableItemDefinition : ScriptableObject
    {
        [SerializeField] private string itemId;
        [SerializeField] private string displayName;
        [SerializeField] private EquipmentSlot slot;
        [SerializeField] private GameObject visualPrefab;
        [SerializeField, Min(0)] private float damageProtection;
        [SerializeField, Min(0)] private float extraCarryCapacity;
        [SerializeField] private bool canBeFoundAsLoot = true;

        public string ItemId => itemId;
        public string DisplayName => displayName;
        public EquipmentSlot Slot => slot;
        public GameObject VisualPrefab => visualPrefab;
        public float DamageProtection => damageProtection;
        public float ExtraCarryCapacity => extraCarryCapacity;
        public bool CanBeFoundAsLoot => canBeFoundAsLoot;

        private void OnValidate()
        {
            damageProtection = Mathf.Max(0f, damageProtection);
            extraCarryCapacity = Mathf.Max(0f, extraCarryCapacity);
        }
    }
}
