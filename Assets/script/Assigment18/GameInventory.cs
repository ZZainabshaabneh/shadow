using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory inv1 = new Inventory();
        inv1.AddItem("Healing Potion");
        inv1.AddItem("Strength Potion");
        Inventory inv2 = new Inventory();
        inv2.AddItem("Elixir");
        inv2.AddItem("Dark Elixir");
        Debug.Log(inv1 + inv2);
        inv1.ShowItems();
        inv2.ShowItems();
    }

    
}
