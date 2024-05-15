using UnityEngine;

public class SellButton : MonoBehaviour
{
    public float offset = 7;
    public LayerMask Layer;

    public int HammerSellPrice = 20;
    public int GunSellPrice = 15;
    public int ArmourSellPrice = 15;
    public int BootsSellPrice = 10;
    public int GlovesSellPrice = 12;
    public int BowArrowSellPrice = 16;
    public int PotionSellPrice = 11;
    public int LanternSellPrice = 9;
    public int TNTSellPrice = 12;
    public int ShieldSellPrice = 50;

    public Money_Manager Money_Manager; // Reference to the Money_Manager script

    public void Sell(GameObject slot)
    {

        Destroy(slot.transform.GetChild(1).gameObject);


       

        if (slot.transform.GetChild(1).gameObject.name == "Hammer(Clone)")
        {
            Money_Manager.currentMoney += HammerSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "Gun(Clone)")
        {
            Money_Manager.currentMoney += GunSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "Armour(Clone)")
        {
            Money_Manager.currentMoney += ArmourSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "Boots(Clone)")
        {
            Money_Manager.currentMoney += BootsSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "Gloves(Clone)")
        {
            Money_Manager.currentMoney += GlovesSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "BowArrow(Clone)")
        {
            Money_Manager.currentMoney += BowArrowSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "Potion(Clone)")
        {
            Money_Manager.currentMoney += PotionSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "Lantern(Clone)")
        {
            Money_Manager.currentMoney += LanternSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "TNT(Clone)")
        {
            Money_Manager.currentMoney += TNTSellPrice;
            Money_Manager.UpdateMoneyText();
        }

        if (slot.transform.GetChild(1).gameObject.name == "Shield(Clone)")
        {
            Money_Manager.currentMoney += ShieldSellPrice;
            Money_Manager.UpdateMoneyText();
        }
    }
}

// RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, offset, Layer);
        //
        // if (hit.collider != null)
        // {
        //   //  GameObject sellItem = hit.collider.gameObject;
        //
        //
        //
        // }
        // else
        // {
        //     Debug.Log("No gfhfd");
        // }
        // }
    


