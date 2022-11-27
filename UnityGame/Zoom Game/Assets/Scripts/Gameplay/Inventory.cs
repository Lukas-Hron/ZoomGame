using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> itemList = new List<Item>();
    private Vector3 itemSlot;
    public float itemOffset = 2f;
    void Start()
    {
        itemSlot = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));
    }
    public void AddItem(Item item)
    {
        itemList.Add(item);
        item.transform.parent = gameObject.transform;
        item.transform.position = transform.position + new Vector3(0, (itemList.Count - 1) * itemOffset, 0);
    }
    public void RemoveItem(string itemName)
    {
        itemList.RemoveAll(x => x.gameObject.name == itemName);
    }
    //Inventory.RemoveItem(Circle);
    //item.gameObject.name
    //adjust offset
    //new Vector3(item.GetComponent<Renderer>().bounds.size.x / 2, item.GetComponent<Renderer>().bounds.size.y / 2, 0);
}
