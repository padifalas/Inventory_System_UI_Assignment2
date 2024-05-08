using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform shopBackpackPosition;
    public Transform backpackChestPosition;

    public float transitionSpeed = 5f;

    private void Start()
    {
        // Ensure the camera is initially positioned at the shop/backpack view
        transform.position = shopBackpackPosition.position;
    }

    public void MoveToShopBackpack()
    {
        // Move the camera to the shop/backpack position
        transform.position = Vector3.Lerp(transform.position, shopBackpackPosition.position, Time.deltaTime * transitionSpeed);
    }

    public void MoveToBackpackChest()
    {
        // Move the camera to the backpack/chest position
        transform.position = Vector3.Lerp(transform.position, backpackChestPosition.position, Time.deltaTime * transitionSpeed);
    }
}
