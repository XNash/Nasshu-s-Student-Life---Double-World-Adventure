using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "Items/Create new recovery item")]


public class RecoveryItem : ItemBase
{
	public RecoveryItem(string name, int value, int price) : base(name, value, price)
    	{

    	}
	    
	public static List<RecoveryItem> recoveryItems = new List<RecoveryItem>()
    	{
        	new RecoveryItem("Milk", 10, 10),
        	new RecoveryItem("Water", 20, 20),
        	new RecoveryItem("Yeast", 30, 30)
    	};

   


    /*
   [Header("HP")]
   [SerializeField] int hpAmount;
   [SerializeField] bool restoreMaxHP;

   [Header("STR")]
   [SerializeField] int strAmount;
   [SerializeField] bool restoreMaxSTR; 
    */
}

