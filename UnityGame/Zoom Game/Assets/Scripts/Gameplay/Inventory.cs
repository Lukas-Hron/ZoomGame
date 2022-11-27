using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    void Start()
    {
        List<Item> itemList = new List<Item>();

        itemList.Add(new Item("Lipstick"));
    }

    //public void AddItem()
    //{
        
    //}
}
