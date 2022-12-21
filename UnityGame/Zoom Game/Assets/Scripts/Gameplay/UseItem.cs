using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItem : MonoBehaviour
{
    public AudioClip playOnUse;
    Player player;
    Animator anim;
    Inventory inventory;
    Item item;
    public bool noanimation;
    [SerializeField] GameObject itemToUse;
    [SerializeField] List<GameObject> ObjectsToEnableAfterAnimation;
    [SerializeField] float animLenght;
    private void Start()
    {
        player = FindObjectOfType<Player>();
        inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
        item = itemToUse.GetComponent<Item>();
        if (!noanimation)
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
            if (!noanimation)
                anim.SetTrigger("item");
            Debug.Log("Item found");
            inventory.RemoveItem(item.name);
            Destroy(itemToUse);
            GetComponent<Collider2D>().enabled = false;
            Invoke(methodName: "OnAnimationFinish", animLenght);
            player.isItemInteract = false;
            player.hasRightItem = false;
            AudioHandler.Instance.PlaySoundEffect(playOnUse);
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

    private void OnAnimationFinish()
    {
        if (ObjectsToEnableAfterAnimation != null)
        {
            foreach (GameObject GmObj in ObjectsToEnableAfterAnimation)
            {
                GmObj.SetActive(true);
            }
        }

    }

    private void OnDisable()
    {
        player.hasRightItem = false;
        player.isItemInteract = false;
    }
}
