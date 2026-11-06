using System;
using System.Collections.Generic;
using UnityEngine;

namespace SurvivalTheLastShelter.Equipment
{
    [Serializable]
    public sealed class EquippedItemEntry
    {
        public EquipmentSlot Slot;
        public string ItemId;
    }

    [Serializable]
    public sealed class CharacterEquipmentLoadout
    {
        [SerializeField] private List<EquippedItemEntry> equippedItems = new List<EquippedItemEntry>();

        public IReadOnlyList<EquippedItemEntry> EquippedItems => equippedItems;

        public bool Equip(WearableItemDefinition item)
        {
            if (item == null || string.IsNullOrWhiteSpace(item.ItemId)) return false;

            equippedItems.RemoveAll(entry => entry == null || entry.Slot == item.Slot);
            equippedItems.Add(new EquippedItemEntry
            {
                Slot = item.Slot,
                ItemId = item.ItemId
            });
            return true;
        }

        public bool Unequip(EquipmentSlot slot)
        {
            return equippedItems.RemoveAll(entry => entry != null && entry.Slot == slot) > 0;
        }

        public string GetItemId(EquipmentSlot slot)
        {
            EquippedItemEntry entry = equippedItems.Find(item => item != null && item.Slot == slot);
            return entry == null ? string.Empty : entry.ItemId;
        }

        public void ReplaceWith(IEnumerable<EquippedItemEntry> entries)
        {
            equippedItems.Clear();
            if (entries == null) return;

            foreach (EquippedItemEntry entry in entries)
            {
                if (entry == null || string.IsNullOrWhiteSpace(entry.ItemId)) continue;
                equippedItems.RemoveAll(existing => existing.Slot == entry.Slot);
                equippedItems.Add(new EquippedItemEntry { Slot = entry.Slot, ItemId = entry.ItemId });
            }
        }
    }
}
