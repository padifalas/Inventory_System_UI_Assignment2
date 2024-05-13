using UnityEngine;
using UnityEngine.UI;

public class BuyArmour : MonoBehaviour
{
    public MoneyManager moneyManager; // Reference to the MoneyManager script
    public string itemName; // Name of the item associated with this buy button
    public GameObject itemIconPrefab; // Prefab of the UI icon representing the item
    public Transform backpackPanel; // Reference to the backpack panel
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
            
            // Find an empty slot in the backpack panel
            foreach (Transform slot in backpackPanel)
            {
                if (slot.childCount == 0) // Check if the slot is empty
                {
                    // Instantiate the item icon at the position of the empty slot
                    GameObject itemIcon = Instantiate(itemIconPrefab, slot);
                    itemIcon.transform.localPosition = Vector3.zero;
                    break; // Exit the loop after placing the item
                }
            }

            Debug.Log(itemName + " bought for $" + itemCost);
        }
        else
        {
            Debug.Log("Insufficient funds to buy " + itemName);
        }
    }
}