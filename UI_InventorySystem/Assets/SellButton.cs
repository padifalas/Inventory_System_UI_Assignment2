using UnityEngine;
using UnityEngine.UI;

public class SellButton : MonoBehaviour
{
    public MoneyManager moneyManager;
    public ShopItem item; // Reference to the ShopItem associated with this sell button

    // Start is called before the first frame update
    void Start()
    {
        // Add a click listener to the button
        GetComponent<Button>().onClick.AddListener(SellItem);
    }

    // Method called when the sell button is clicked
    public void SellItem()
    {
        // Call the SellItem method of the MoneyManager script and pass the ShopItem
        moneyManager.SellItem(item);
    }
}