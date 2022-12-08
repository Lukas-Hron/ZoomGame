using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    Player player;
    Animator anim;
    Inventory inventory;
    Item item;
    GameObject itemToUse;
    [SerializeField] string itemName;
    private void Start()
    {
        player = FindObjectOfType<Player>();
        //item = GameObject.Find("Key").GetComponent<Item>();
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();

        itemToUse = GameObject.Find(itemName);
        item = itemToUse.GetComponent<Item>();
        anim = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        if (gameObject.tag == "UsableItem")
        {
            Debug.Log("Keyhole Clicked");
        }

        if (inventory.itemList.Contains(item))
        {
            anim.SetTrigger("item");
            Debug.Log("Item found");
            inventory.RemoveItem(item.name);
            Destroy(itemToUse);
            GetComponent<Collider2D>().enabled = false;
            player.isItemInteract = false;
            player.hasRightItem = false;
        }
    }

    private void OnMouseEnter()
    {

        if (inventory.itemList.Contains(item))
        {
            player.hasRightItem = true;
            player.SetCurserSprite(item.GetComponent<SpriteRenderer>().sprite);
        }
        else
        {
            player.hasRightItem = false;
        }

        player.isItemInteract = true;
    }
    private void OnMouseExit()
    {
        player.hasRightItem = false;
        player.isItemInteract = false;
    }
}
