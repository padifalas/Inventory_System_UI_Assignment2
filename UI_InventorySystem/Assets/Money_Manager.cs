using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Money_Manager : MonoBehaviour
{
    public int TotalMoney = 100; // Starting balance
     public int currentMoney;// Current amount of money
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

  //  public Transform boxAboveButton;

   
     

    
    private void Start()
    {
        currentMoney = TotalMoney; 
        UpdateMoneyText();
    } 


    public void UpdateMoneyText()
    {
        moneyText.text =  "Money: $" + currentMoney.ToString();
    }
   


}

