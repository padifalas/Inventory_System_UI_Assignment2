using UnityEngine;
using UnityEngine.UI;

public class Reorganize : MonoBehaviour
{
    public BackpackManager backpackManager;
    public GameObject[] itemSlots;

    public void ReorganizeBackpack()
    {
        // Trigger the reorganization of the backpack
        ShuffleItems();
        Debug.Log("Items reorganized");
    }

    void ShuffleItems()
    {
        // Shuffle UI item GameObjects randomly without affecting the slots
        for (int i = 0; i < itemSlots.Length; i++)
        {
            int randomIndex = Random.Range(i, itemSlots.Length); // Random index from i to end of array
            Vector3 tempPosition = itemSlots[i].transform.position;
            itemSlots[i].transform.position = itemSlots[randomIndex].transform.position;
            itemSlots[randomIndex].transform.position = tempPosition;
        }
    }
}