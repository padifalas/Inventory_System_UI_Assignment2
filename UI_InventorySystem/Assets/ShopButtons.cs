using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtons : MonoBehaviour
{
    [SerializeField] 
    private GameObject Hammer;
    private GameObject Gun;

    public MoneyManager MoneyManager;
    public bool hasItemOne = false;
    public bool storedItem = false;

    public float hammerCost = 2.99f; // Cost of the hammer
    public float GunCost = 3.99f;
    public float ArmourCost = 14.99f;
    public float BootsCost = 17.99f;
    public float GlovesCost = 4.99f;
    public float BowArrowCost = 8.99f;
    public float GreenPotionCost = 6.99f;
    public float LanternCost = 3.99f;
    public float TntCost = 9.99f;
    public float ShieldCost = 44.99f;
    

    public void buyHammer()
    {
        if (MoneyManager.currentMoney >= hammerCost && !hasItemOne)
        {
            // Deduct the cost of the hammer
            MoneyManager.DeductAmount((int)hammerCost);
            
            // Move the hammer to the backpack panel
            Hammer.SetActive(true); // Activate the hammer
            Hammer.transform.position = new Vector3(-0.39f, 1.660756f, -0.001353522f);
            
            hasItemOne = true;
            Debug.Log("Hammer Bought");
        }
        else
        {
            Debug.Log("Insufficient funds to buy the hammer or hammer already purchased.");
        }
    }
    
    public void buyGun()
    {
        if (MoneyManager.currentMoney >= hammerCost && !hasItemOne)
        {
            // Deduct the cost of the hammer
            MoneyManager.DeductAmount((int)GunCost);
            
            // Move the hammer to the backpack panel
            Gun.SetActive(true); // Activate the hammer
            Hammer.transform.position = new Vector3(1.47f, 660756f, -0.001353522f);
            
            hasItemOne = true;
            Debug.Log("Gun Bought");
        }
        else
        {
            Debug.Log("Insufficient funds to buy the hammer or hammer already purchased.");
        }
    }
    void Start()
    {
        // Disable the hammer at the start
        Hammer.SetActive(true);
        Gun.SetActive(true);
    }

    void Update()
    {
        
    }
}