using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money_Manager : MonoBehaviour
{
    public int TotalMoney = 100; // Starting balance
    public int currentMoney;// Current amount of money
    public TextMeshProUGUI moneyText;

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
    
    
    
    public int HammerSellPrice = 10;
    public int GunSellPrice = 5;
    public int ArmourSellPrice = 15;
    public int BootsSellPrice = 5;
    public int GlovesSellPrice = 10;
    public int BowArrowSellPrice = 5;
    public int PotionSellPrice = 20;
    public int LanternSellPrice = 15;
    public int TNTSellPrice = 20;
    public int ShieldSellPrice = 50;
    
    public Color defaultColor = Color.white;
    public Color noMoneyColor = Color.red;

    private void Start()
    {
        currentMoney = TotalMoney; 
        UpdateMoneyText();
    } 

    public void UpdateMoneyText()
    {
        moneyText.text = "Money: $" + currentMoney.ToString();

        // Change text color if funds are insufficient
        if (currentMoney < 5) // Change here
        {
            moneyText.color = noMoneyColor;
        }
        else
        {
            moneyText.color = defaultColor;
        }
    }
}