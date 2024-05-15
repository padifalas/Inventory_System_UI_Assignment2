using UnityEngine;

public class StoreButton : MonoBehaviour
{
    public GameObject chestSlots; // Reference to the chest slots GameObject
    public PopupManager popupManager; // Reference to the PopupManager

    // Function to handle storing the item from the backpack slot to the chest slots
    public void StoreItemInChest(Transform backpackSlot)
    {
        if (backpackSlot != null && chestSlots != null && backpackSlot.childCount > 0)
        {
            GameObject itemToStore = backpackSlot.GetChild(0).gameObject; // Get the item from the backpack slot
            // Find an available chest slot
            Transform availableSlot = FindAvailableChestSlot();
            if (availableSlot != null)
            {
                // Move the item to the chest slot
                itemToStore.transform.SetParent(availableSlot);
                itemToStore.transform.localPosition = Vector3.zero; // Center the item in the slot
                itemToStore.SetActive(true); // Ensure the item is active
            }
            else
            {
                popupManager.ShowPopup("No available chest slot."); // Show popup message
            }
        }
        else
        {
            popupManager.ShowPopup("No item in backpack slot."); // Show popup message
        }
    }

    // Function to find an available chest slot
    private Transform FindAvailableChestSlot()
    {
        if (chestSlots != null)
        {
            foreach (Transform slot in chestSlots.transform)
            {
                if (slot.childCount == 0)
                {
                    return slot;
                }
            }
        }
        return null; // No available chest slot found
    }
}