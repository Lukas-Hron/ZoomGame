using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarConstellation : MonoBehaviour
{
    public Sprite starOn;
    public Sprite starOff;

    private void ChangeSprite(SpriteRenderer tileSpriteRenderer, Sprite newSprite)
    {
        tileSpriteRenderer.sprite = newSprite;
    }

    public void TurnStar()
    {
        ToggleOn();

    }

    public void ToggleOn()
    {
        Star star = GameObject.FindGameObjectWithTag("Star").GetComponent<Star>();
        //Reference Tile from tile class to toggle targeted tiles active bool
        star.ToggleActive();
        Debug.Log(star.litStar);

        //Sets to active or inactive sprite (On/Off)
        if (star.litStar)
            ChangeSprite(star.GetComponent<SpriteRenderer>(), starOn);
        else
            ChangeSprite(star.GetComponent<SpriteRenderer>(), starOff);

    }
}
