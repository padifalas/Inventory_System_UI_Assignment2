using UnityEngine;
using UnityEngine.UI;

public class PanelScrolling : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject backpackPanel;
    public GameObject chestPanel;

    public Button shopToBackBtn;
    public Button backToChestBtn;

    private int currentPanelIndex = 0; // Index to keep track of the current set of panels

    void Start()
    {
        // Add onClick listeners to the buttons
        shopToBackBtn.onClick.AddListener(ScrollToBackpack);
        backToChestBtn.onClick.AddListener(ScrollToChest);

        Debug.Log("Functions are there"); 
    }

    // Method to scroll to the backpack and chest panels
    private void ScrollToBackpack()
    {
        // Show the backpack and chest panels
        shopPanel.SetActive(false);
        backpackPanel.SetActive(true);
        chestPanel.SetActive(true);

        // Update the current panel index
        currentPanelIndex = 1;
    }

    // Method to scroll back to the shop and backpack panels
    private void ScrollToChest()
    {
        // Show the shop and backpack panels
        shopPanel.SetActive(true);
        backpackPanel.SetActive(true);
        chestPanel.SetActive(false);

        // Update the current panel index
        currentPanelIndex = 0;
    }
}