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
        //instantiate constellation as parent to lines, allows for multiple constellations
        constellation = gameObject.transform.parent.GetComponent<StarConstellation>();
    }
    public void CheckLine()
    {
        //check if all stars attached to line are active, if so turn that line on.
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
