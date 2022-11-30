using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite tileOn;
    public Sprite tileOff;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }
    private void ChangeSprite(Sprite tileOn, Sprite tileOff)
    {
            spriteRenderer.sprite = tileOn;
            spriteRenderer.sprite = tileOff;
    }
 
    public void OnMouseDown()
    {
        //if (gameObject.name == "Tile1")
            //if (spriteRenderer.sprite = tileOff)
            //{
            //    ChangeSprite();
            //}
            //else
            //    ChangeSprite(tileOff);
    }
}
public class Tile : MonoBehaviour
{
    public bool active;
    public void ToggleActive()
    {
        active = !active;
    }
}
