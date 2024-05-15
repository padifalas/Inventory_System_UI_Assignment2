using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellButtonManager : MonoBehaviour
{


    public int HammerPrice = 20;
    public int GunPrice = 15;
    public int ArmourPrice = 15;
    public int BootsPrice = 10;
    public int GlovesPrice = 12;
    public int BowArrowPrice = 16;
    public int PotionPrice = 11;
    public int LanternPrice = 9;
    public int TNTPrice = 12;
    public int ShieldPrice = 50;

public Money_Manager moneyManager;

 public LayerMask layerMask;
 public float raycastDistance = 1.0f;


 public void Sell()
 {
     RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, raycastDistance, layerMask);

     if (hit.collider != null)
     {
         GameObject objectAboveButton = hit.collider.gameObject;
         Destroy(objectAboveButton);
         Debug.Log("Object above button:" + objectAboveButton);


         if (objectAboveButton.name == "Hammer(Clone)")
         {
             moneyManager.currentMoney += HammerPrice;
            moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "Gun(Clone)") 
         {
             moneyManager.currentMoney += GunPrice;
             moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "Armour(Clone)")
         {
             moneyManager.currentMoney += ArmourPrice;
             moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "Boots(Clone)")
         {
             moneyManager.currentMoney += BootsPrice;
             moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "Gloves(Clone)")
         {
             moneyManager.currentMoney += GlovesPrice;
             moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "Bow&Arrow(Clone)")
         {
             moneyManager.currentMoney += BowArrowPrice;
             moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "GreenPotion(Clone)")
         {
             moneyManager.currentMoney += PotionPrice;
             moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "Lantern(Clone)")
         {
             moneyManager.currentMoney += LanternPrice;
             moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "TNT(Clone)")
         {
             moneyManager.currentMoney += TNTPrice;
             moneyManager.UpdateMoneyText();
         }
         if (objectAboveButton.name == "Shield(Clone)")
         {
             moneyManager.currentMoney += ShieldPrice;
             moneyManager.UpdateMoneyText();
         }


     }
     else
     {
         Debug.Log("No object");
     }

     
 }
}
