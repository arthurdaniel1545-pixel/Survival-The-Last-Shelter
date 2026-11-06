using UnityEngine;
using SurvivalTheLastShelter.Inventory;

namespace SurvivalTheLastShelter.Building
{
    public sealed class CraftingStation
    {
        public bool CanCraft(CraftingRecipe recipe, InventorySystem inventory)
        {
            if (recipe == null || inventory == null) return false;
            foreach (CraftingIngredient ingredient in recipe.Ingredients)
            {
                if (ingredient == null) continue;
                if (inventory.GetQuantity(ingredient.ItemId) < ingredient.Quantity) return false;
            }
            return true;
        }

        public bool TryCraft(CraftingRecipe recipe, InventorySystem inventory)
        {
            if (!CanCraft(recipe, inventory)) return false;

            foreach (CraftingIngredient ingredient in recipe.Ingredients)
            {
                if (ingredient == null) continue;
                if (!inventory.Remove(ingredient.ItemId, ingredient.Quantity)) return false;
            }

            return inventory.Add(recipe.ResultItemId, recipe.ResultCategory, recipe.ResultQuantity, recipe.ResultWeight);
        }
    }
}
