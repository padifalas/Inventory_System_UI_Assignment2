using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScrollController : MonoBehaviour
{
    public RectTransform shopPanel;
    public RectTransform backpackPanel;
    public RectTransform chestPanel;
    public float scrollSpeed = 350f;

    private Vector3 initiallShopPosition;
    private Vector3 intitialBackpackPosition;
    private Vector3 initiallChestPosition;

    private void Start()
    {
        // Record the original positions of the panels
        initiallShopPosition = shopPanel.localPosition;
        intitialBackpackPosition = backpackPanel.localPosition;
        initiallChestPosition = chestPanel.localPosition;
    }

    public void ScrollToLeft()
    {
        // Calculate the target position for scrolling left
        Vector3 targetShopPosition = initiallShopPosition - Vector3.right * Screen.width;
        Vector3 targetBackpackPosition = intitialBackpackPosition - Vector3.right * Screen.width;
        Vector3 targetChestPosition = initiallChestPosition - Vector3.right * Screen.width;

        // Move the panels towards the target position
        shopPanel.localPosition = Vector3.Lerp(shopPanel.localPosition, targetShopPosition, Time.deltaTime * scrollSpeed);
        backpackPanel.localPosition = Vector3.Lerp(backpackPanel.localPosition, targetBackpackPosition, Time.deltaTime * scrollSpeed);
        chestPanel.localPosition = Vector3.Lerp(chestPanel.localPosition, targetChestPosition, Time.deltaTime * scrollSpeed);
    }

    public void ScrollToRight()
    {
        // Calculate the target position for scrolling right
        Vector3 targetShopPosition = initiallShopPosition;
        Vector3 targetBackpackPosition = intitialBackpackPosition;
        Vector3 targetChestPosition = initiallChestPosition;

        // Move the panels towards the target position
        shopPanel.localPosition = Vector3.Lerp(shopPanel.localPosition, targetShopPosition, Time.deltaTime * scrollSpeed);
        backpackPanel.localPosition = Vector3.Lerp(backpackPanel.localPosition, targetBackpackPosition, Time.deltaTime * scrollSpeed);
        chestPanel.localPosition = Vector3.Lerp(chestPanel.localPosition, targetChestPosition, Time.deltaTime * scrollSpeed);
    }
}
