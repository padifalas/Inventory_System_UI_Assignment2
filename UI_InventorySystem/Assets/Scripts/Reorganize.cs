using UnityEngine;
using UnityEngine.UI;

public class Reorganize : MonoBehaviour
{
    public BackpackManager backpackManager;
    public GameObject[] itemSlots;

    public void ReorganizeBackpack()
    {
        // Function for the Reorganize Button whichTrigger the function to reorga of the backpack
        ShuffleItems();
        Debug.Log("Items reorganized");
    }

    void ShuffleItems()
    {
        // Shuffle  items - theire GameObjects of coure- slots stay. GOs move
        for (int i = 0; i < itemSlots.Length; i++)
        {
            int randomSlots = Random.Range(i, itemSlots.Length); // Random index from i to end of array
            Vector3 itemPosi = itemSlots[i].transform.position;
            itemSlots[i].transform.position = itemSlots[randomSlots].transform.position;
            itemSlots[randomSlots].transform.position = itemPosi;
        }
    }
}