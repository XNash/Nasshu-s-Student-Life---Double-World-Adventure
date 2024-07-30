using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBase : MonoBehaviour
{
    public string iName;
    public int value;
    public int price;

    public ItemBase(string itemName, int itemValue, int itemPrice)
    { 
        iName = itemName;
        value = itemValue;
        price = itemPrice;
    }

    public ItemBase()
    {
        iName = "";
        value = 0;
        price = 0;
    }
}


/*
public class ItemBase : ScriptableObject
{
    [SerializeField] string name;
    [SerializeField] string description;
    [SerializeField] Sprite icon;

    public string Name => name;

    public string Description => description;

    public Sprite Icon => icon;
}
*/