using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelControl : MonoBehaviour
{
    public Camera mainCamera;
    public RectTransform shopPanel;
    public RectTransform backpackPanel;
    public RectTransform chestPanel;
    public float scrollSpeed = 350f;

    private Vector3 initialCameraPosition;
    private Vector3 initialShopPosition;
    private Vector3 initialBackpackPosition;
    private Vector3 initialChestPosition;

    public Button backButton;
    public Button nextButton;

    private bool showShopAndBackpack = true;

    private void Start()
    {
        // Record the original positions of the camera and panels
        initialCameraPosition = mainCamera.transform.position;
        initialShopPosition = shopPanel.localPosition;
        initialBackpackPosition = backpackPanel.localPosition;
        initialChestPosition = chestPanel.localPosition;

        // Initially show only shop and backpack panels
        ShowShopAndBackpackPanels();
        
        // Initially show next button
        nextButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(false);
    }

    public void TogglePanels()
    {
        showShopAndBackpack = !showShopAndBackpack;

        if (showShopAndBackpack)
        {
            ShowShopAndBackpackPanels();
            nextButton.gameObject.SetActive(true);
            backButton.gameObject.SetActive(false);
        }
        else
        {
            ShowBackpackAndChestPanels();
            nextButton.gameObject.SetActive(false);
            backButton.gameObject.SetActive(true);
        }
    }

    private void ShowShopAndBackpackPanels()
    {
        mainCamera.transform.position = initialCameraPosition;
        shopPanel.gameObject.SetActive(true);
        backpackPanel.gameObject.SetActive(true);
        chestPanel.gameObject.SetActive(false);

        shopPanel.localPosition = initialShopPosition;
        backpackPanel.localPosition = initialBackpackPosition;
    }

    private void ShowBackpackAndChestPanels()
    {
        mainCamera.transform.position = initialCameraPosition + Vector3.right * Screen.width;
        shopPanel.gameObject.SetActive(false);
        backpackPanel.gameObject.SetActive(true);
        chestPanel.gameObject.SetActive(true);

        backpackPanel.localPosition = initialShopPosition;
        chestPanel.localPosition = initialBackpackPosition;
    }

    public void NextBtn()
    {
        if (showShopAndBackpack)
        {
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, initialCameraPosition, Time.deltaTime * scrollSpeed);
        }
        else
        {
           
        }
    }
    
    
    public void BackBtn()
    {
        if (showShopAndBackpack)
        {
            mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, initialCameraPosition - Vector3.right * Screen.width, Time.deltaTime * scrollSpeed);
        }
        else
        {
           
        }
    }
}
