using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SellButton : MonoBehaviour
{
    public Money_Manager moneyManager;
    public LayerMask layerMask;
    public float raycastDistance = 3f;
    
    
    public GameObject Hammer,
        Gun,
        Armour,
        Boots,
        Gloves,
        BowArrow,
        Potion,
        Lantern,
        TNT,
        Shield;

    public int HammerPrice = 10;
    public int GunPrice = 5;
    public int ArmourPrice = 15;
    public int BootsPrice = 5;
    public int GlovesPrice = 10;
    public int BowArrowPrice = 5;
    public int PotionPrice = 20;
    public int LanternPrice = 15;
    public int TNTPrice = 20;
    public int ShieldPrice = 50; 

   
   
    
    public void Sell()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, raycastDistance, layerMask);

        if (hit.collider != null)
        {
            GameObject objectAboveButton = hit.collider.gameObject;
            Destroy(objectAboveButton);
            Debug.Log("Object aboce button:" + objectAboveButton);


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
            if (objectAboveButton.name == "BowArrow(Clone)")
            {
                moneyManager.currentMoney += BowArrowPrice;
                moneyManager.UpdateMoneyText();
            }
            if (objectAboveButton.name == "Potion(Clone)")
            {
                moneyManager.currentMoney +=  PotionPrice;
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