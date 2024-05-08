using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement: MonoBehaviour
{
    public Transform ChestTargetPosition;
    public Transform ShopTargetPosition;


    public void MoveToChest()
    {
        transform.position = ChestTargetPosition.position;
        
    }

    public void MoveToShop()
    {
        transform.position = ShopTargetPosition.position;
    }
}