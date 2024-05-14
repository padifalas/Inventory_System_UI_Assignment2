using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Money_Manager : MonoBehaviour
{
    public int startingAmount = 100; // Starting balance
    public int currentMoney; // Current amount of money
    public TextMeshProUGUI moneyText;

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

    public Transform boxAboveButton;

   
     

    
    private void Start()
    {
        UpdateMoneyText();
    }

   public  void UpdateMoneyText()
    {
        moneyText.text = "Money: $" + currentMoney.ToString();
    }

    public void DeductButton1()
    {
       if (currentMoney >= 10)
        {
            currentMoney -= HammerPrice;
            UpdateMoneyText();
            Debug.Log("HAMMER BOUGHT");
        }

        
    }

    public void DeductButton2()
    {
        if (currentMoney >= 5)
        {
            currentMoney -= GunPrice;
            UpdateMoneyText();
        }
        
    }

    public void DeductButton3()
    {
        if (currentMoney >= 15)
        {
            currentMoney -= ArmourPrice;
            UpdateMoneyText();
        }

    }

    public void DeductButton4()
    {
        if (currentMoney >= 5)
        {
            currentMoney -= BootsPrice;
            UpdateMoneyText();
        }
    }

    public void DeductButton5()
    {
        if (currentMoney >= 10)
        {
            currentMoney -= GlovesPrice;
            UpdateMoneyText();
        }
    }

    public void DeductButton6()
    {
        if (currentMoney >= 5)
        {
            currentMoney -= BowArrowPrice;
            UpdateMoneyText();
        }
    }

    public void DeductButton7()
    {
        if (currentMoney >= 20)
        {
            currentMoney -= PotionPrice;
            UpdateMoneyText();
        }
    }

    public void DeductButton8()
    {
        if (currentMoney >= 15)
        {
            currentMoney -= LanternPrice;
            UpdateMoneyText();
        }
    }
    public void DeductButton9()
    {
        if (currentMoney >= 20)
        {
            currentMoney -= TNTPrice;
            UpdateMoneyText();
        }
    }
    
    public void DeductButton10()
    {
        if (currentMoney >= 50)
        {
            currentMoney -= ShieldPrice;
            UpdateMoneyText();
        }
    }

    
    
   public void SellHammer()
    {
        currentMoney += HammerPrice;
        UpdateMoneyText();
    }

   public void SellGun()
    {
        currentMoney += GunPrice;
        UpdateMoneyText();
    }

    public void SellArmour()
    { 
        currentMoney += ArmourPrice;
        UpdateMoneyText();
    }

    public void SellBoots()
    { 
        currentMoney += BootsPrice;
        UpdateMoneyText();
    }

    public void SellGloves()
    {
        currentMoney += GlovesPrice;
        UpdateMoneyText();
    }

    public void SellBowArrow()
    {
        currentMoney += BowArrowPrice;
        UpdateMoneyText();
    }

    public void SellPotion()
    {
        currentMoney += PotionPrice;
        UpdateMoneyText();
    }

    public void SellLantern()
    {
        currentMoney += LanternPrice;
        UpdateMoneyText();
    }

    public void SellTNT()
    {
        currentMoney += TNTPrice;
        UpdateMoneyText();
    }
    
    public void SellShield()
    {
        currentMoney += ShieldPrice;
        UpdateMoneyText();
    }
  



}

