using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class MoneyManager : MonoBehaviour
{
    private int startingAmount = 100; // Starting balance
    public int currentMoney; // current amount of money
    public TextMeshProUGUI moneyText; // reference to the TextMeshPro text element

    private void Start()
    {
        currentMoney = startingAmount; // initialize current money to starting money
        UpdateMoneyText(); // update money text on start
    } 
//method to get current amount of money
    public int GetBalance()
    {
        return startingAmount;
    }

    public bool DeductAmount(int amount)
    {
        if (amount <= startingAmount)
        {
            startingAmount -= amount;
            return true;
        }
        else
        {
            Debug.Log("Insufficient funds!");
            return false;
        }
    }

    public void AddAmount(int amount)
    {
        startingAmount += amount;
    }
    
    //method to update method text
    public void UpdateMoneyText()
    {
        if (moneyText != null)
        {
            moneyText.text = "Money: $" + currentMoney.ToString(); // Update text with current money
        }
    }

}
