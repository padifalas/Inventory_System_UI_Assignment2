using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ShopItemButton : MonoBehaviour
{
    public MoneyManager moneyManager; // Reference to the MoneyManager script
    public GameObject itemPrefab; // Prefab of the item to be added to the backpack
    public Transform backpackPanel; // Reference to the backpack panel

    public float itemCost; // Cost of the item

    public void Start()
    {
        // Add a click listener to the button
        GetComponent<Button>().onClick.AddListener(BuyItem);
    }
    
    
    // Method to handle the purchase of the item
    public void BuyItem()
    {
        // Check if the player has enough money
        if (moneyManager.currentMoney >= itemCost)
        {
            // Deduct the cost of the item
            moneyManager.Buy((int)itemCost);

            // Find an empty slot in the backpack panel
            foreach (Transform slot in backpackPanel)
            {
                if (slot.childCount == 0) // Check if the slot is empty
                {
                    // Instantiate the item prefab and place it in the empty slot
                    GameObject item = Instantiate(itemPrefab, slot);
                    item.transform.localPosition = Vector3.zero;
                    break;
                }
            }
        }
        else
        {
            Debug.Log("Insufficient funds to buy the item.");
        }
    }
}
