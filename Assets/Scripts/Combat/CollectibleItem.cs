using UnityEngine;
using SurvivalTheLastShelter.Inventory;
using SurvivalTheLastShelter.Interaction;

namespace SurvivalTheLastShelter.Combat
{
    public sealed class CollectibleItem : MonoBehaviour, IInteractable
    {
        [SerializeField] private string itemId;
        [SerializeField] private ItemCategory category = ItemCategory.Material;
        [SerializeField] private int quantity = 1;
        [SerializeField] private float unitWeight = 0.5f;

        public string InteractionPrompt => "Coletar " + itemId;

        public bool CanInteract(GameObject interactor)
        {
            return !string.IsNullOrWhiteSpace(itemId) && quantity > 0;
        }

        public void Interact(GameObject interactor)
        {
            InventoryHolder holder = interactor != null ? interactor.GetComponent<InventoryHolder>() : null;
            InventorySystem inventory = holder != null ? holder.Inventory : null;
            if (inventory == null) return;

            if (inventory.Add(itemId, category, quantity, unitWeight))
            {
                Destroy(gameObject);
            }
        }
    }
}
