using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyButtonn : MonoBehaviour
{
    public Money_Manager moneyManager;
    public int currentMoney;
    public BagManager bagManager;

    public GameObject Hammer,
        Gun,
        Armour,
        Boots,
        Gloves,
        BowArrow,
        Potion,
        Lantern,
        TNT,
        Shield;// Example field for the hammer prefab

    public Transform StorageSlotArea;

    public void BuyHammer()
    {
        BuyItem(moneyManager.HammerPrice, Hammer);
    }

    public void BuyGun()
    {
        BuyItem(moneyManager.GunPrice, Gun);
    }

    public void BuyArmour()
    {
        BuyItem(moneyManager.ArmourPrice, Armour);
    }

    public void BuyBoots()
    {
        BuyItem(moneyManager.BootsPrice, Boots);
    }

    public void BuyGloves()
    {
        BuyItem(moneyManager.GlovesPrice, Gloves);
    }

    public void BuyBowArrow()
    {
        BuyItem(moneyManager.BowArrowPrice, BowArrow);
    }

    public void BuyPotion()
    {
        BuyItem(moneyManager.PotionPrice, Potion);
    }

    public void BuyLantern()
    {
        BuyItem(moneyManager.LanternPrice, Lantern);
    }

    public void BuyTNT()
    {
        BuyItem(moneyManager.TNTPrice, TNT);
    }

    public void BuyShield()
    {
        BuyItem(moneyManager.ShieldPrice, Shield);
    }

    private void BuyItem(int price, GameObject itemPrefab)
    {
        if (moneyManager.currentMoney >= price)
        {
            GameObject CloneLocation = bagManager.WhichSlot();
            if (CloneLocation != null)
            {
                moneyManager.currentMoney -= price;
                moneyManager.UpdateMoneyText();

                GameObject ClonedItem = Instantiate(itemPrefab, CloneLocation.transform.position, Quaternion.identity, CloneLocation.transform);
                ClonedItem.transform.position = new Vector3(CloneLocation.transform.position.x, CloneLocation.transform.position.y, -4);
                ClonedItem.transform.rotation = itemPrefab.transform.rotation;
            }
        }
        else
        {
            Debug.Log("Not enough money to purchase the item.");
            // You can display a message to the player indicating insufficient funds
        }
    }
}
