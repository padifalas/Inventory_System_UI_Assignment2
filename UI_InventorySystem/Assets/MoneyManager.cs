using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
// Define a structure to hold information about each shop item
[System.Serializable]
public class ShopItem
{
    public string itemName; // Name of the item
    public GameObject itemIcon; // UI icon for the item
    public int itemCost; // Cost of the item
    public int sellPrice; 
}

public class MoneyManager : MonoBehaviour
{
    public int startingAmount = 100; // Starting balance
    public int currentMoney; // Current amount of money
    public TextMeshProUGUI moneyText; // Reference to the TextMeshPro text element

    // Reference to the backpack panel
    public Transform backpackPanel;
    
    public GameObject hammerPrefab; // Example field for the hammer prefab
    public GameObject gunPrefab;
    public GameObject armourPrefab;

    public GameObject BootsPrefab,
        GlovesPrefab,
        BowArrowPrefab,
        GreenPotionPrefab,
        LanternPrefab,
        TNTprefab,
        ShieldPrefab; 



    // Method called when the script starts
    public void Start()
    {
        currentMoney = startingAmount; // Initialize current money to starting money
        UpdateMoneyText(); // Update money text on start
    }

    // Method to get current amount of money
    public int GetBalance()
    {
        return currentMoney;
    }

    // Method to deduct money when buying an item
    public bool Buy(ShopItem item)
    {
        if (currentMoney >= item.itemCost)
        {
            currentMoney -= item.itemCost; // Deduct item cost from current money
            UpdateMoneyText(); // Update money text after deduction
            AddItemToInventory(item); // Add item to inventory
            return true; // Return true if the purchase was successful
        }
        else
        {
            Debug.Log("Insufficient funds!");
            return false; // Return false if the player doesn't have enough money
        }
    }
    
    // Method to add money when selling an item
    public void SellItem(ShopItem item)
    {
        if (currentMoney >= item.sellPrice)
        {
            currentMoney += item.sellPrice; // Add sell price to current money
            UpdateMoneyText(); // Update money text after selling item

            // Remove item from backpack (implement this based on your backpack UI logic)
            RemoveItemFromBackpack(item);
            Debug.Log(item.itemName + " was sold for $" + item.sellPrice);
        }
        else
        {
            Debug.Log("Insufficient funds to sell " + item.itemName);
        }
    }



  

    // Method to update money text in the UI
    public void UpdateMoneyText()
    {
        if (moneyText != null)
        {
            moneyText.text = "Money: $" + currentMoney.ToString(); // Update text with current money
        }
    }

    // Method to add item to inventory
    // Method to add item to inventory
    public void AddItemToInventory(ShopItem item)
    {
        // Instantiate the item prefab
        
        GameObject itemInstance = Instantiate(item.itemIcon);

        // Find an empty slot in the backpack panel
        foreach (Transform slot in backpackPanel)
        {
            if (slot.childCount == 0) // Check if the slot is empty
            {
                // Set the parent of the item prefab to the empty slot
                itemInstance.transform.SetParent(slot);
                itemInstance.transform.localPosition = Vector3.zero; // Center the item within the slot
                break; // Exit the loop after placing the item
            }
        }
    }

    
    // Method to remove item from backpack
    private void RemoveItemFromBackpack(ShopItem item)
    {
        // Implement logic to remove the item from the backpack
    }
}
