using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Define a structure to hold information about each shop item
[System.Serializable]
public class ShopItem
{
    public string itemName; // Name of the item
    public Sprite itemIcon; // UI icon for the item
    public float itemCost; // Cost of the item
}

public class MoneyManager : MonoBehaviour
{
    private int startingAmount = 100; // Starting balance
    public int currentMoney; // Current amount of money
    public TextMeshProUGUI moneyText; // Reference to the TextMeshPro text element

    // Dictionary to store items and their quantities in the player's inventory
    public Dictionary<string, int> inventory = new Dictionary<string, int>();

    // Array of shop items
    public ShopItem[] shopItems;

    // Method called when the script starts
    private void Start()
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
    // Method to deduct money when buying an item
    public bool Buy(float cost)
    {
        if (currentMoney >= cost)
        {
            currentMoney -= (int)cost; // Cast cost to int to truncate decimal places
            return true; // Return true if the purchase was successful
        }
        else
        {
            Debug.Log("Insufficient funds!");
            return false; // Return false if the player doesn't have enough money
        }
    }


    // Method to add money when selling an item
    public void Sell(float amount)
    {
        currentMoney += Mathf.RoundToInt(amount);
        UpdateMoneyText(); // Update money text after adding money
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
    public void AddItemToInventory(string itemName)
    {
        if (inventory.ContainsKey(itemName))
        {
            inventory[itemName]++;
        }
        else
        {
            inventory[itemName] = 1;
        }
    }

    // Method to remove item from inventory
    public void RemoveItemFromInventory(string itemName)
    {
        if (inventory.ContainsKey(itemName) && inventory[itemName] > 0)
        {
            inventory[itemName]--;
        }
    }
}
