using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarConstellation : MonoBehaviour
{
    public Sprite starOn;
    public Sprite starOff;
    public Sprite lineOn;
    public Sprite lineOff;
    [SerializeField] private List<GameObject> lines;

    private void ChangeSprite(SpriteRenderer starSpriteRenderer, Sprite newSprite)
    {
        starSpriteRenderer.sprite = newSprite;
    }

    public void ChangeSpriteLine(SpriteRenderer lineSpriteRenderer, Sprite newSprite)
    {
        lineSpriteRenderer.sprite = newSprite;
    }

    public void ActivateStar(List<GameObject> stars, GameObject clickedStar)
    {
        StartCoroutine(ToggleOn(clickedStar.GetComponent<Star>(), 0));
        foreach (GameObject star in stars)
            StartCoroutine(ToggleOn(star.GetComponent<Star>(), 1));
    }

    public IEnumerator ToggleOn(Star star, float delayTime)
    {
        
        yield return new WaitForSeconds(delayTime);
        //Reference Tile from tile class to toggle targeted tiles active bool
        star.ToggleActive();
        foreach (GameObject starLine in lines)
            starLine.GetComponent<StarLine>().CheckLine();
        Debug.Log(star.litStar);

        //Sets to active or inactive sprite (On/Off)
        if (star.litStar)
            ChangeSprite(star.GetComponent<SpriteRenderer>(), starOn);
        else
            ChangeSprite(star.GetComponent<SpriteRenderer>(), starOff);
    }
}
