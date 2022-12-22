using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
    private Vector3 itemSlot;
    public float itemOffset = 2f;
 
    void Start()
    {
        itemSlot = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
    }
    public void AddItem(Item item,float size)
    {
        itemList.Add(item);
        try
        {
        item.GetComponent<Animator>().enabled = false;
        }
        catch
        {

        }
        item.GetComponent<SpriteRenderer>().sortingOrder = 97;
        item.transform.parent = gameObject.transform;
        item.transform.position = transform.position + new Vector3(0, (itemList.Count - 1) * itemOffset, 0);
        item.transform.localScale = new Vector3(size,size,size);
    }
    public void RemoveItem(string itemName)
    {
        itemList.RemoveAll(x => x.gameObject.name == itemName);
    }

    //Inventory.RemoveItem(Circle); include in use item script
    //item.gameObject.name search for name of gameobject

    //adjust offset
    //new Vector3(item.GetComponent<Renderer>().bounds.size.x / 2, item.GetComponent<Renderer>().bounds.size.y / 2, 0);
}
