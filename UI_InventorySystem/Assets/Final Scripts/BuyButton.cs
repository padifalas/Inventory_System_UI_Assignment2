using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public MoneyManager moneyManager; // Reference to the MoneyManager script
    public string itemName; // Name of the item associated with this buy button
    public GameObject itemIcon; // UI icon representing the item
    public float itemCost; // Cost of the item

    public void Start()
    {
        // Add a click listener to the button
        GetComponent<Button>().onClick.AddListener(BuyItem);
    }

    public void BuyItem()
    {
        // Check if the player has enough money to buy the item
        if (moneyManager.Buy((int)itemCost))
        {
            // Add the item to the inventory
            moneyManager.AddItemToInventory(itemName);
            
            // Instantiate the item icon in the backpack or wherever you want it to appear
            Instantiate(itemIcon);

            Debug.Log(itemName + " bought for $" + itemCost);
        }
        else
        {
            Debug.Log("Insufficient funds to buy " + itemName);
        }
    }
}
