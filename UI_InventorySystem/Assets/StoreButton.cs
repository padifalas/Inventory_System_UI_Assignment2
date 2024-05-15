using UnityEngine;

public class StoreButton : MonoBehaviour
{
    public BackpackManager backpackManager; // Reference to the BackpackManager script
    public ChestManager chestManager; // Reference to the ChestManager script

    public void StoreSelectedItemToChest()
    {
        // Check if a slot in the backpack is selected
        GameObject selectedBackpackSlot = backpackManager.SelectedSlot;
        if (selectedBackpackSlot != null)
        {
            // Check if there's an available slot in the chest
            GameObject availableChestSlot = chestManager.GetAvailableSlot();
            if (availableChestSlot != null)
            {
                // Transfer the item from the backpack to the chest
                Transform itemTransform = selectedBackpackSlot.transform.GetChild(0); // Assuming the item is a child of the slot
                itemTransform.SetParent(availableChestSlot.transform);
                itemTransform.localPosition = Vector3.zero; // Center the item in the chest slot

                // Make the backpack slot available again
                backpackManager.MakeSlotAvailable(selectedBackpackSlot);

                Debug.Log("Item stored in the chest.");
            }
            else
            {
                Debug.Log("No available slot in the chest.");
            }
        }
        else
        {
            Debug.Log("No slot selected in the backpack.");
        }
    }
}