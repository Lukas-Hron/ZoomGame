using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomLayerItem : ZoomLayerObject
{
    private Item item;

    public ZoomLayerItem(Item i,GameObject gameObject) : base(gameObject)
    {
        item = i;
    }
    
    public void setItem(Item i)
    {
        item = i;
    }
    public Item getItem()
    {
        return item;
    }
}
