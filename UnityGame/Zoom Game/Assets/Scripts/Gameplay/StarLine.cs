using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class StarLine : MonoBehaviour
{
    [SerializeField] private List<GameObject> connectedStars;

    public bool litLine;
    StarConstellation constellation;

    private void Start()
    {
        constellation = gameObject.transform.parent.GetComponent<StarConstellation>();
    }
    public void CheckLine()
    {
        bool allOn = connectedStars.All(x => x.GetComponent<Star>().litStar);

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
