using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private Item[] inventory;
    private Vector2[] itemPositions;
    
    public Inventory()
    {
        inventory = new Item[5];
        itemPositions = new Vector2[5];
    }
    
    public void setItemPosition(string itemName, Vector2 newPosition)
    {
        
    }

    private bool itemExists(string itemName)
    {
        foreach (Item item in inventory)
        {
            if (item.getName() == itemName)
            {
                return true;
            }
           
        }
        return false;
    }
}
