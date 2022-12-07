using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private List<GameObject> linesConnected;
    [SerializeField] private List<GameObject> starsConnected;

    public bool litStar;
    public void ToggleActive()
    {
        //Toggles active between true and false
        litStar = !litStar;      
    }
    public void OnMouseDown()
    {
        //Get GameBoard class to use call on TurnTile function
        
        GameObject.Find("StarConstellation").GetComponent<StarConstellation>().ActivateStar(starsConnected, gameObject);
        
        //Debug.Log(gameObject.name);
    }

}
