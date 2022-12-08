using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curser : MonoBehaviour
{
    public Player player;
    public Sprite currentItem;
    SpriteRenderer sprn;
    public List<Sprite> cursers;
    int currentCurser;
    int lastframeCurser;

    private void Start()
    {
        Cursor.visible = false;
        sprn = GetComponent<SpriteRenderer>();
        Debug.Log(cursers.Count);
        sprn.sprite = cursers[0];
        
    }


    private void Update()
    {
       transform.position =(Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);

        currentCurser = 0;
        if (player.isZooming)
        {
            currentCurser = 1;
        }

        if (player.canClick)
        {
            currentCurser = 4;
        }

        if (player.isItemInteract)
        {
            if (player.hasRightItem)
            {
                currentCurser = 100;
            }
            else
            {
                currentCurser = 5;
            }

        }


        if (player.isPanning)
        {
            currentCurser = 2;
        }


        if(lastframeCurser != currentCurser)
        {
            if (currentCurser == 100)
                sprn.sprite = currentItem;
            else
            sprn.sprite = cursers[currentCurser];

            Debug.Log("changed");
        }


        lastframeCurser = currentCurser;
    }
}
