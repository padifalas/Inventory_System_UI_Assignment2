using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public MoneyManager moneyManager;
    public GameObject backpackPanel;
    public Transform shopContent;
    public Transform backpackContent;
    public GameObject itemSlotPrefab; // Prefab for item slot in the shop
    public GameObject backpackSlotPrefab; // Prefab for empty slot in the backpack

    // Define items and their prices
    private Item[] items = {
        new Item("Hammer", 3),
        new Item("Gun", 5),
        new Item("Armour", 15),
        new Item("Boots", 15),
        new Item("Gloves", 5),
        new Item("Bow&Arrow", 8),
        new Item("Potion", 6),
        new Item("Lantern", 7),
        new Item("TNT", 4),
        new Item("Shield", 50),
    };

    private void Start()
    {
        PopulateShop();
        PopulateBackpack();
    }

    private void PopulateShop()
    {
        foreach (Item item in items)
        {
            // Instantiate item slot in the shop panel
            GameObject newItemSlot = Instantiate(itemSlotPrefab, shopContent);
            newItemSlot.transform.Find("ItemName").GetComponent<Text>().text = item.name;
            newItemSlot.transform.Find("ItemPrice").GetComponent<Text>().text = "$" + item.price.ToString();
            Button buyButton = newItemSlot.transform.Find("BuyButton").GetComponent<Button>();
            
            // Add listener to the buy button to call BuyItem method with the corresponding item
            buyButton.onClick.AddListener(() => BuyItem(item));
        }
    }

    private void PopulateBackpack()
    {
        // Populate backpack with empty slots
        for (int i = 0; i < backpackPanel.transform.childCount; i++)
        {
            Instantiate(backpackSlotPrefab, backpackContent);
        }
    }

    public void BuyItem(Item item)
    {
        // Check if the player has enough funds to buy the item
        if (moneyManager.GetBalance() >= item.price)
        {
            if (moneyManager.DeductAmount(item.price))
            {
                Debug.Log(item.name + " bought successfully!");

                // Find an empty slot in the backpack panel
                Transform emptySlot = FindEmptySlot();
                if (emptySlot != null)
                {
                    // Move the bought item to the empty slot in the backpack panel
                    GameObject newItem = new GameObject(item.name);
                    newItem.transform.SetParent(emptySlot);
                    newItem.transform.localPosition = Vector3.zero;
                    newItem.AddComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + item.name); // Assuming you have sprites with the same name as items
                }
                else
                {
                    Debug.Log("Backpack is full!");
                }
            }
            else
            {
                Debug.Log("Failed to buy " + item.name + "!");
            }
        }
        else
        {
            Debug.Log("Insufficient funds to buy " + item.name + "!");
        }
    }

    private Transform FindEmptySlot()
    {
        foreach (Transform slot in backpackContent)
        {
            if (slot.childCount == 0)
            {
                return slot;
            }
        }
        return null;
    }
}

public class Item
{
    public string name;
    public int price;

    public Item(string name, int price)
    {
        this.name = name;
        this.price = price;
    }
}
