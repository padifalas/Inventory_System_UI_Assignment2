using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagManager : MonoBehaviour
{
    public List<GameObject> slots = new List<GameObject>();
    bool[] canHold;

    private void Start()
    {
        // Initialize canHold array with the same length as slots list
        canHold = new bool[slots.Count];
        for (int i = 0; i < slots.Count; i++)
        {
            canHold[i] = true; // All slots are initially available
        }
    }

    public GameObject WhichSlot()
    {
        for (int i = 0; i < slots.Count; i++)
        {
            if (canHold[i])
            {
                canHold[i] = false; // Mark slot as unavailable
                return slots[i];
            }
        }
        // If no slot is available, return null or handle it according to your logic
        return null;
    }
}