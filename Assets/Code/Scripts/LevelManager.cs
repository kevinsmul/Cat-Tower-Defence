using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public int currency;
    
    // Start is called before the first frame update
    void Start()
    {
        main = this;
        currency = 100; // dit moet in de start blijven niet in de Awake komen
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseCurrency(int amount){
        currency += amount;
    }

    public bool SpendCurrency(int amount){
        if (amount <= currency){
            // Buy Item
            currency -= amount;
            return true;
        } else {
            Debug.Log("you dont have any money");
            return false;
        }
    }
}

    