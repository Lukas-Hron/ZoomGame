using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    [SerializeField] private List<GameObject> linesConnected;
    [SerializeField] private List<GameObject> starsConnected;
    Player player;

    public bool litStar;

   private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public void ToggleActive()
    {
        //Toggles active between true and false
        litStar = !litStar;      
    }
    public void OnMouseDown()
    {
        //Get GameBoard class to use call on TurnTile function
        player.canClick = false;
        gameObject.transform.parent.GetComponent<StarConstellation>().ActivateStar(starsConnected, gameObject);
        
        //Debug.Log(gameObject.name);
    }
    private void OnMouseEnter()
    {
        if (player.canInteract)
        {
            player.canClick = true;
        }
    }
    private void OnMouseExit()
    {
        player.canClick = false;
    }
}
