using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLine : MonoBehaviour
{
    [SerializeField] private List<GameObject> connectedStars;

    public bool litLine;
    StarConstellation constellation;

    private void Start()
    {
        constellation = GameObject.Find("StarConstellation").GetComponent<StarConstellation>();
    }
    public void CheckLine()
    {
        foreach (GameObject connectedStar in connectedStars)
        {
            bool allOn = true;
            if (!connectedStar.GetComponent<Star>().litStar)
            {
                allOn = false;
            }

            if (allOn)
            {
                litLine = true;
                constellation.ChangeSpriteLine(GetComponent<SpriteRenderer>(), constellation.lineOn);
            }
            else
            {
                litLine = false;
                constellation.ChangeSpriteLine(GetComponent<SpriteRenderer>(), constellation.lineOff);
            }
        }
    }
}
