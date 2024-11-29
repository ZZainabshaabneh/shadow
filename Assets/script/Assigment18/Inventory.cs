using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<string> itemlist = new List<string>();
    public void AddItem(string item)
    {
        itemlist.Add(item);
    }
    public void ShowItems()
    {
        foreach (string item in itemlist)
        {
            Debug.Log(item);
        }
    }
    public static Inventory operator +(Inventory a, Inventory b)
    {
        Inventory sumObject = new Inventory();
        foreach (string obj in a.itemlist)
        {
            sumObject.AddItem(obj);

        }
        foreach (string obj in b.itemlist)
        {
            sumObject.AddItem(obj);

        }
        return sumObject;
    }
    void Start()
    {

    }

}
