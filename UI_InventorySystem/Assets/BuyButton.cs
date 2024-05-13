using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    public MoneyManager moneyManager; // Reference to the MoneyManager script
    public ShopItem item; // Reference to the ShopItem associated with this buy button

    // Start is called before the first frame update
    void Start()
    {
        // Add a click listener to the button
        GetComponent<Button>().onClick.AddListener(BuyItem);
    }

    // Method called when the buy button is clicked
    public void BuyItem()
    {
        // Call the Buy method of the MoneyManager script and pass the ShopItem
        if (moneyManager.Buy(item))
        {
            Debug.Log(item.itemName + " purchased!");
        }
        else
        {
            Debug.Log("Insufficient funds to purchase " + item.itemName);
        }
    }
}