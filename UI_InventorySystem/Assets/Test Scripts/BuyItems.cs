using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class BuyItem : MonoBehaviour
{
    public MoneyManager moneyManager; // Reference to the MoneyManager script
    public ItemType itemType; // Enum or string identifier to specify the type of item
    public GameObject itemIconPrefab; // Prefab of the UI icon representing the item
    public Transform backpackPanel; // Reference to the backpack panel
    public float itemCost; // Cost of the item

    public enum ItemType
    {
        Hammer,
        Gun,
        Armour,
        Boots,
        Gloves,
        BowArrow,
        GreenPotion,
        Lantern,
        TNT,
        Shield,
        // Add more item types as needed
    }

    public void Start()
    {
        // Add a click listener to the button
        GetComponent<Button>().onClick.AddListener(BuyItems);
    }

    public void BuyItems()
    {
        // Check if the player has enough money to buy the item
        if (moneyManager.Buy(itemCost))
        {
            // Execute specific function based on the item type
            switch (itemType)
            {
                case ItemType.Hammer:
                    BuyHammer(); 
                    break;
                case ItemType.Gun:
                    BuyGun();
                    break;
                case ItemType.Armour:
                    BuyArmour();
                    break;
            
                case ItemType.Boots:
                    BuyBoots(); 
                    break;
            
                case ItemType.Gloves:
                    BuyGloves();
                    break;
            
                case ItemType.BowArrow:
                    BuyBowArrow();
                    break;
            
                case ItemType.GreenPotion:
                    BuyGreenPotion();
                    break;
            
                case ItemType.Lantern:
                    BuyLantern();
                    break;
            
                case ItemType.TNT:
                    BuyTNT();
                    break;
            
                case ItemType.Shield:
                    BuyShield();
                    break; 
                // Add more cases for additional item types
                default:
                    Debug.LogError("Unknown item type: " + itemType);
                    break;
            }
            // Update money text after buying the item
            moneyManager.UpdateMoneyText();
            
            // Find an empty slot in the backpack panel
            Transform emptySlot = backpackPanel.Cast<Transform>().FirstOrDefault(slot => slot.childCount == 0);
            if (emptySlot != null)
            {
                // Instantiate the item icon at the position of the empty slot
                GameObject itemIcon = Instantiate(itemIconPrefab, emptySlot);
                itemIcon.transform.localPosition = Vector3.zero;
            }
        }
        else
        {
            Debug.Log("Insufficient funds to buy " + itemType);
        }
    }

    
    public void BuyHammer() 
    {
        // Add the Hammer to the player's inventory or perform specific actions
        moneyManager.AddItemToInventory("Hammer");
        Debug.Log("Hammer bought for $" + itemCost);
    }
    public void BuyGun()
    {
        // Add the gun to the player's inventory or perform specific actions
        moneyManager.AddItemToInventory("Gun");
        Debug.Log("Gun bought for $" + itemCost);
    }

    public void BuyArmour()
    {
        
        moneyManager.AddItemToInventory("Armour");
        Debug.Log("Armour bought for $" + itemCost);
    }

    public void BuyBoots()
    {
       
        moneyManager.AddItemToInventory("Boots");
        Debug.Log("Boots bought for $" + itemCost);
    }
    
    public void BuyGloves()
    {
       
        moneyManager.AddItemToInventory("Gloves");
        Debug.Log("Gloves bought for $" + itemCost);
    }
    
    public void BuyBowArrow()
    {

        moneyManager.AddItemToInventory("BowArrow");
        Debug.Log("BowArrow bought for $" + itemCost);
    }
    
    public void BuyGreenPotion()
    {
   
        moneyManager.AddItemToInventory("Potion");
        Debug.Log("Potion bought for $" + itemCost);
    }
    
    public void BuyLantern()
    {
        
        moneyManager.AddItemToInventory("Lanterns");
        Debug.Log("Lantern bought for $" + itemCost);
    }
    
    public void BuyTNT()
    {
        
        moneyManager.AddItemToInventory("TNT");
        Debug.Log("TNT bought for $" + itemCost);
    }
    
    public void BuyShield()
    {
        
        moneyManager.AddItemToInventory("Shield");
        Debug.Log("Shield bought for $" + itemCost);
    }
}
