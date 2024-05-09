using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelScrollController : MonoBehaviour
{
    public RectTransform shopPanel;
    public RectTransform backpackPanel;
    public RectTransform chestPanel;
    public float scrollSpeed = 350f;

    private Vector3 initiallShopPosition;
    private Vector3 intitialBackpackPosition;
    private Vector3 initiallChestPosition;
    
    public Button backButton;
    public Button nextButton;

    private void Start()
    {
        // these the original positions of the panels
        //initializes them
        initiallShopPosition = shopPanel.localPosition;
        intitialBackpackPosition = backpackPanel.localPosition;
        initiallChestPosition = chestPanel.localPosition;
        
        // Hide the back button initially
        backButton.gameObject.SetActive(false);
    }

    public void NextBtn()
    {
        // calculatess the target position for scrolling left
        //subtract screen width from the original/initial positions that are in the start method at the top
        Vector3 targetShopPosition = initiallShopPosition - Vector3.right * Screen.width;
        Vector3 targetBackpackPosition = intitialBackpackPosition - Vector3.right * Screen.width;
        Vector3 targetChestPosition = initiallChestPosition - Vector3.right * Screen.width;

        // Move the panels towards the target position
        shopPanel.localPosition = Vector3.Lerp(shopPanel.localPosition, targetShopPosition, Time.deltaTime * scrollSpeed); //vector3.lerp is basically linear interpolation - smotthly transitions objects(panels) fom one position to another
        backpackPanel.localPosition = Vector3.Lerp(backpackPanel.localPosition, targetBackpackPosition, Time.deltaTime * scrollSpeed);
        chestPanel.localPosition = Vector3.Lerp(chestPanel.localPosition, targetChestPosition, Time.deltaTime * scrollSpeed);
        
        // Deactivate next button, activate back button
        nextButton.gameObject.SetActive(false);
        backButton.gameObject.SetActive(true);
    }

    public void BackBtn()
    {
        // Calculate the target position for scrolling right 
        //resets the target posi - moves panels BACK to initial position
        Vector3 targetShopPosition = initiallShopPosition;
        Vector3 targetBackpackPosition = intitialBackpackPosition;
        Vector3 targetChestPosition = initiallChestPosition;

        // Move the panels towards the target position
        shopPanel.localPosition = Vector3.Lerp(shopPanel.localPosition, targetShopPosition, Time.deltaTime * scrollSpeed);
        backpackPanel.localPosition = Vector3.Lerp(backpackPanel.localPosition, targetBackpackPosition, Time.deltaTime * scrollSpeed);
        chestPanel.localPosition = Vector3.Lerp(chestPanel.localPosition, targetChestPosition, Time.deltaTime * scrollSpeed);
        
        // Activate next button, deactivate back button
        nextButton.gameObject.SetActive(true);
        backButton.gameObject.SetActive(false);
    }
}
