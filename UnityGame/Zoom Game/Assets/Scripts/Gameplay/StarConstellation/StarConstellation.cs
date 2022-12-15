using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class StarConstellation : MonoBehaviour
{
    public Sprite starOn;
    public Sprite starOff;
    public Sprite lineOn;
    public Sprite lineOff;
    public bool isFinished = false;
    [SerializeField] private float delayT = 0.1f;
    [SerializeField] private List<GameObject> lines;
    [SerializeField] private List<GameObject> stars;

    private void ChangeSprite(SpriteRenderer starSpriteRenderer, Sprite newSprite)
    {
        starSpriteRenderer.sprite = newSprite;
    }
    public void ChangeSpriteLine(SpriteRenderer lineSpriteRenderer, Sprite newSprite)  //not sure if redundant. Called upon in StarLine
    {
        lineSpriteRenderer.sprite = newSprite;
    }

    public void ActivateStar(List<GameObject> stars, GameObject clickedStar)        
    {
        //Toggles clicked star and connected ones
        StartCoroutine(ToggleOn(clickedStar.GetComponent<Star>(), 0));
        foreach (GameObject star in stars)
            StartCoroutine(ToggleOn(star.GetComponent<Star>(), delayT));
        StartCoroutine(checkWin(delayT));
    }

    public IEnumerator ToggleOn(Star star, float delayTime)
    {
        //Add delay variable to delay toggles
        yield return new WaitForSeconds(delayTime);
        star.ToggleActive();
        foreach (GameObject starLine in lines)
            starLine.GetComponent<StarLine>().CheckLine();

        //Sets to active or inactive sprite (On/Off)
        if (star.litStar)
            ChangeSprite(star.GetComponent<SpriteRenderer>(), starOn);
        else
            ChangeSprite(star.GetComponent<SpriteRenderer>(), starOff);
    }

    public IEnumerator checkWin(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);

        bool allOn = lines.All(x => x.GetComponent<StarLine>().litLine);

        if (allOn)
        {
            foreach (Collider2D col in GetComponentsInChildren<Collider2D>())
            {
                col.enabled = false;
            }
            isFinished = true;
        }
    }
}
