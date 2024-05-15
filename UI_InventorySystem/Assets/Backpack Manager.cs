using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackManager : MonoBehaviour
{
    public List<GameObject> slots = new List<GameObject>();
    public bool[] slotAvailability;

    public void Start()
    {
        // Initialize slot availability array
        slotAvailability = new bool[slots.Count];
        for (int i = 0; i < slots.Count; i++)
        {
            slotAvailability[i] = true; // All slots are initially available
        }
    }

    public GameObject WhichSlot()
    {
        // Find and return the first available slot
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
    
    public void ShuffleItems()
    {
        // Shuffle items randomly in the backpack
        for (int i = 0; i < slots.Count; i++)
        {
            int randomIndex = Random.Range(0, slots.Count);
            (slots[i], slots[randomIndex]) = (slots[randomIndex], slots[i]);
        }
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
}