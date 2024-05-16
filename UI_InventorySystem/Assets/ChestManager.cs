using UnityEngine;
using UnityEngine.UI; 

public class ChestManager : MonoBehaviour
{
    public Transform chestPanel; 
    public Button upgradeButton; 

    public int currentSlotIndex = 5;

    public void Start()
    {
        
        upgradeButton.interactable = currentSlotIndex < chestPanel.childCount;//upgrade button stops working when all slots are active
       
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