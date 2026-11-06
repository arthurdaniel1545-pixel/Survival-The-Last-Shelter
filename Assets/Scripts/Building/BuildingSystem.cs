using System.Collections.Generic;
using UnityEngine;
using SurvivalTheLastShelter.Inventory;

namespace SurvivalTheLastShelter.Building
{
    public sealed class BuildingSystem
    {
        public bool CanBuild(BuildableDefinition buildable, InventorySystem inventory)
        {
            if (buildable == null || inventory == null) return false;
            foreach (BuildCost cost in buildable.Costs)
            {
                if (cost == null) continue;
                if (inventory.GetQuantity(cost.ItemId) < cost.Quantity) return false;
            }
            return true;
        }

        public bool TryBuild(BuildableDefinition buildable, InventorySystem inventory, Vector3 position, Quaternion rotation, out GameObject instance)
        {
            instance = null;
            if (!CanBuild(buildable, inventory) || buildable.Prefab == null) return false;

            foreach (BuildCost cost in buildable.Costs)
            {
                if (cost == null) continue;
                if (!inventory.Remove(cost.ItemId, cost.Quantity)) return false;
            }

            instance = UnityEngine.Object.Instantiate(buildable.Prefab, position, rotation);
            return true;
        }
    }
}
