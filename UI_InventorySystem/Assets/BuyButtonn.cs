using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyButtonn : MonoBehaviour
{
    public Money_Manager MoneyManager; // Reference to the MoneyManager script
    public Transform[] Slots;
    public Transform backpackPanel;
    public Vector3 sizes = new Vector3(70f, 70f, 0);
    private int Lastpoint = -1;

    public GameObject Hammer, Gun, Armour, Boots, Gloves, BowArrow, GreenPotion, Lantern, TNT, Shield;

    public void BuyHammer()
    {

        if (MoneyManager.currentMoney >= MoneyManager.HammerPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Hammer, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellHammer();

                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Hammer, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;

                    MoneyManager.SellHammer();
                    return;
                    
                    Debug.Log("HAMMER BOUGHT");
                }


            }
        }
    }

    public void BuyGun()
    {

        if (MoneyManager.currentMoney >= MoneyManager.GunPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Gun, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);


                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellGun();
                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Gun, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellGun();
                    return;
                }


            }
        }
    }

    public void BuyArmour()
    {

        if (MoneyManager.currentMoney >= MoneyManager.ArmourPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Armour, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.1f, 0);


                    CloneObject.transform.localScale = new Vector3(50, 50, 0);

                    Lastpoint = i;
                    MoneyManager.SellArmour();
                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Armour, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellArmour();
                    return;
                }


            }
        }
    }

    public void BuyBoots()
    {

        if (MoneyManager.currentMoney >= MoneyManager.BootsPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Boots, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.5f, 0);


                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellBoots();
                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Boots, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellBoots();
                    return;
                }


            }
        }
    }

    public void BuyGloves()
    {

        if (MoneyManager.currentMoney >= MoneyManager.GlovesPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Gloves, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.5f, 0);


                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellGloves();
                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Gloves, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellGloves();
                    return;
                }


            }
        }
    }

    public void BuyBowArrow()
    {

        if (MoneyManager.currentMoney >= MoneyManager.BowArrowPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(BowArrow, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.2f, 0);


                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellBowArrow();
                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(BowArrow, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0f, 0);

                    CloneObject.transform.localScale = new Vector3(200, 200, 0);

                    Lastpoint = i;
                    MoneyManager.SellBowArrow();
                    return;
                }


            }
        }
    }

    public void BuyPotion()
    {

        if (MoneyManager.currentMoney >= MoneyManager.PotionPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject =
                        Instantiate(GreenPotion, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.5f, 0);


                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellPotion();
                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject =
                        Instantiate(GreenPotion, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellPotion();
                    return;
                }


            }
        }
    }

    public void BuyLantern()
    {

        if (MoneyManager.currentMoney >= MoneyManager.LanternPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Lantern, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.4f, 0);


                    CloneObject.transform.localScale = new Vector3(40, 40, 0);

                    Lastpoint = i;
                    MoneyManager.SellLantern();
                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(Lantern, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellLantern();
                    return;
                }


            }
        }
    }

    public void BuyTNT()
    {

        if (MoneyManager.currentMoney >= MoneyManager.TNTPrice)
        {
            int startIndex = Lastpoint + 1;

            if (startIndex >= Slots.Length)
            {
                startIndex = 0;
            }

            for (int i = startIndex; i < Slots.Length; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(TNT, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);


                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellTNT();
                    return;

                }
            }

            for (int i = 0; i < startIndex; i++)
            {
                Transform space = Slots[i];

                Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                if (colliders.Length == 0)
                {
                    GameObject CloneObject = Instantiate(TNT, space.position, Quaternion.identity, backpackPanel);
                    CloneObject.transform.position = new Vector3(space.position.x, space.position.y - 0.3f, 0);

                    CloneObject.transform.localScale = sizes;

                    Lastpoint = i;
                    MoneyManager.SellTNT();


                    return;
                }

                void BuyShield()
                {

                    if (MoneyManager.currentMoney >= MoneyManager.ShieldPrice)
                    {
                        int startIndex = Lastpoint + 1;

                        if (startIndex >= Slots.Length)
                        {
                            startIndex = 0;
                        }

                        for (int i = startIndex; i < Slots.Length; i++)
                        {
                            Transform space = Slots[i];

                            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                            if (colliders.Length == 0)
                            {
                                GameObject CloneObject = Instantiate(Shield, space.position, Quaternion.identity,
                                    backpackPanel);
                                CloneObject.transform.position =
                                    new Vector3(space.position.x, space.position.y - 0.3f, 0);


                                CloneObject.transform.localScale = sizes;

                                Lastpoint = i;
                                MoneyManager.DeductButton9();

                                return;

                            }
                        }

                        for (int i = 0; i < startIndex; i++)
                        {
                            Transform space = Slots[i];

                            Collider2D[] colliders = Physics2D.OverlapPointAll(space.position);

                            if (colliders.Length == 0)
                            {
                                GameObject CloneObject = Instantiate(Shield, space.position, Quaternion.identity,
                                    backpackPanel);
                                CloneObject.transform.position =
                                    new Vector3(space.position.x, space.position.y - 0.3f, 0);

                                CloneObject.transform.localScale = sizes;

                                Lastpoint = i;
                                MoneyManager.SellShield();


                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}



                        
    
                
            
        
    
    