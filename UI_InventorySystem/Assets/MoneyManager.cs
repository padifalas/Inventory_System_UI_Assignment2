using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    public int currentMoney; // current amount of money
    public TextMeshProUGUI moneyText; // reference to the TextMeshPro text element

    // Dictionary to store items and their quantities
    public Dictionary<string, int> inventory = new Dictionary<string, int>();

    // Array of shop items
    public ShopItem[] shopItems;

    private void Start()
    {
        currentMoney = startingAmount; // initialize current money to starting money
        UpdateMoneyText(); // update money text on start
    }

    // Method to get current amount of money
    public int GetBalance()
    {
        return currentMoney;
    }

    // Method to deduct money
    public bool DeductAmount(int amount)
    {
        if (amount <= currentMoney)
        {
            currentMoney -= amount;
            return true;
        }
        else
        {
            Debug.Log("Insufficient funds!");
            return false;
        }
    }

    // Method to add money
    public void AddAmount(int amount)
    {
        currentMoney += amount;
    }

    // Method to update money text
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
