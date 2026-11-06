using System;
using System.Collections.Generic;
using UnityEngine;

namespace SurvivalTheLastShelter.Inventory
{
    public enum ItemCategory
    {
        Food,
        Water,
        Material,
        Tool,
        Weapon,
        Clothing
    }

    [Serializable]
    public sealed class InventoryEntry
    {
        public string ItemId;
        public ItemCategory Category;
        public int Quantity;
        public float Weight;
    }

    public sealed class InventorySystem
    {
        private readonly Dictionary<string, InventoryEntry> _entries = new Dictionary<string, InventoryEntry>(StringComparer.Ordinal);

        public IReadOnlyDictionary<string, InventoryEntry> Entries => _entries;
        public float MaxCarryWeight = 30f;

        public float CurrentWeight
        {
            get
            {
                float total = 0f;
                foreach (InventoryEntry entry in _entries.Values)
                {
                    if (entry != null) total += entry.Weight * entry.Quantity;
                }
                return total;
            }
        }

        public bool CanAdd(string itemId, int quantity, float unitWeight)
        {
            if (string.IsNullOrWhiteSpace(itemId) || quantity <= 0) return false;
            return CurrentWeight + unitWeight * quantity <= MaxCarryWeight;
        }

        public bool Add(string itemId, ItemCategory category, int quantity, float unitWeight)
        {
            if (string.IsNullOrWhiteSpace(itemId) || quantity <= 0) return false;
            if (!CanAdd(itemId, quantity, unitWeight)) return false;

            if (_entries.TryGetValue(itemId, out InventoryEntry existing) && existing != null)
            {
                existing.Quantity += quantity;
                existing.Weight = unitWeight;
                existing.Category = category;
            }
            else
            {
                _entries[itemId] = new InventoryEntry
                {
                    ItemId = itemId,
                    Category = category,
                    Quantity = quantity,
                    Weight = unitWeight
                };
            }

            return true;
        }

        public bool Remove(string itemId, int quantity)
        {
            if (string.IsNullOrWhiteSpace(itemId) || quantity <= 0) return false;
            if (!_entries.TryGetValue(itemId, out InventoryEntry existing) || existing == null) return false;
            if (existing.Quantity < quantity) return false;

            existing.Quantity -= quantity;
            if (existing.Quantity <= 0) _entries.Remove(itemId);
            return true;
        }

        public int GetQuantity(string itemId)
        {
            if (string.IsNullOrWhiteSpace(itemId)) return 0;
            return _entries.TryGetValue(itemId, out InventoryEntry entry) && entry != null ? entry.Quantity : 0;
        }

        public void Clear()
        {
            _entries.Clear();
        }
    }
}
