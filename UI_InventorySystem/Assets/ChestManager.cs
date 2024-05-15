using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ChestManager : MonoBehaviour
{
    public List<GameObject> slots = new List<GameObject>();
    public bool[] slotAvailability;
    
    public int initialSlotCount = 3; // Initial number of slots in the chest
    public int maxSlotCount = 10; // Maximum number of slots in the chest
    public GameObject chestSlotPrefab; // Prefab of the chest slot UI element
    public Transform chestPanel; // Reference to the chest panel where slots will be instantiated
    public Button upgradeButton; // Button to upgrade the chest
    
    private int currentSlotCount; // Current number of slots in the chest


    public void Start()
    {
        currentSlotCount = initialSlotCount;
        InstantiateChestSlots();
        CheckUpgradeAvailability();
        
        
        // Initialize slot availability array
        slotAvailability = new bool[slots.Count];
        for (int i = 0; i < slots.Count; i++)
        {
            slotAvailability[i] = true; // All slots are initially available
        }
    }

    public GameObject GetAvailableSlot()
    {
        // Find and return the first available slot in the chest
        for (int i = 0; i < slots.Count; i++)
        {
            if (slotAvailability[i])
            {
                slotAvailability[i] = false; // Mark slot as unavailable
                return slots[i];
            }
        }
        // If no slot is available, return null or handle it according to your logic
        return null;
    }

    public void MakeSlotAvailable(GameObject slot)
    {
        int index = slots.IndexOf(slot);
        if (index != -1 && index < slotAvailability.Length)
        {
            slotAvailability[index] = true; // Mark slot as available
        }
        else
        {
            Debug.LogError("Slot not found or index out of range.");
        }
    }
    
    public void InstantiateChestSlots()
    {
        for (int i = 0; i < currentSlotCount; i++)
        {
            GameObject slot = Instantiate(chestSlotPrefab, chestPanel);
            slot.name = "ChestSlot_" + i;
        }
    }

    public void UpgradeChest()
    {
        if (currentSlotCount < maxSlotCount)
        {
            currentSlotCount++;
            InstantiateChestSlots();
            CheckUpgradeAvailability();
        }
    }

    public void CheckUpgradeAvailability()
    {
        upgradeButton.interactable = currentSlotCount < maxSlotCount;
    }
}
