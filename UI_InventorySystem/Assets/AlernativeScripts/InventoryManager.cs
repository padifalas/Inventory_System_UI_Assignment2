using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public GameObject shopPanel;
    public GameObject backpackPanel;
    public GameObject chestPanel;

    public Button nextButton;
    public Button backButton;
    public CameraController cameraController;
    private void Start()
    {
        
        
        // Initially, show the shop and backpack panels, hide the chest panel
        shopPanel.SetActive(true);
        backpackPanel.SetActive(true);
        chestPanel.SetActive(false);

        // Hide the back button initially
        backButton.gameObject.SetActive(false);
    }

    public void NextButtonClicked()
    {
        // Hide shop panel... show backpack and chest
        shopPanel.SetActive(false);
        backpackPanel.SetActive(true);
        chestPanel.SetActive(true); 

        // Deactivate next button, activate back button
        nextButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
        
        // Move camera to backpack/chest view
        cameraController.MoveToBackpackChest();

    }

    public void BackButtonClicked()
    {
        // Show shop and backpack panels, hide chest panel
        shopPanel.SetActive(true);
        backpackPanel.SetActive(true);
        chestPanel.SetActive(false); 

        // Activate next button, deactivate back button
        nextButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(false);
        
        // Move camera to shop/backpack view
        cameraController.MoveToShopBackpack();
    }
}
