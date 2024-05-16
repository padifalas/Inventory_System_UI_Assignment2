using UnityEngine;
using UnityEngine.UI; 

public class ChestManager : MonoBehaviour
{
    public Transform chestPanel; 
    public Button upgradeButton; 

    public int currentSlotIndex = 0;

    public void Start()
    {
        // Disable upgrade button if all slots are already active
        upgradeButton.interactable = currentSlotIndex < chestPanel.childCount;

        // Activate initial slots if needed (optional)
        ActivateNextSlot();
    }

    public void UpgradeChest()
    {
        ActivateNextSlot();

        // Disable upgrade button if all slots are now active
        upgradeButton.interactable = currentSlotIndex < chestPanel.childCount;
    }

    public void ActivateNextSlot()
    {
        if (currentSlotIndex < chestPanel.childCount)
        {
            Transform slot = chestPanel.GetChild(currentSlotIndex);
            slot.gameObject.SetActive(true);
            currentSlotIndex++;
        }
    }
}