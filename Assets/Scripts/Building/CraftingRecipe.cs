using System;
using UnityEngine;
using SurvivalTheLastShelter.Inventory;

namespace SurvivalTheLastShelter.Building
{
    [Serializable]
    public sealed class CraftingIngredient
    {
        public string ItemId;
        public ItemCategory Category = ItemCategory.Material;
        public int Quantity = 1;
    }

    [CreateAssetMenu(fileName = "CraftingRecipe", menuName = "Survival/Crafting/Recipe")]
    public sealed class CraftingRecipe : ScriptableObject
    {
        [SerializeField] private string recipeId;
        [SerializeField] private string resultItemId;
        [SerializeField] private ItemCategory resultCategory = ItemCategory.Tool;
        [SerializeField] private int resultQuantity = 1;
        [SerializeField] private float resultWeight = 1f;
        [SerializeField] private CraftingIngredient[] ingredients = Array.Empty<CraftingIngredient>();

        public string RecipeId => recipeId;
        public string ResultItemId => resultItemId;
        public ItemCategory ResultCategory => resultCategory;
        public int ResultQuantity => resultQuantity;
        public float ResultWeight => resultWeight;
        public CraftingIngredient[] Ingredients => ingredients;
    }
}
