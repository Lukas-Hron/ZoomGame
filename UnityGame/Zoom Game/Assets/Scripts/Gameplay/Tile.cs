using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool active;
    public void ToggleActive()
    {
        //Toggles active between true and false
        active = !active;
    }
    public void OnMouseDown()
    {
        //Get GameBoard class to use call on TurnTile function
        GameObject.Find("GridPuzzle").GetComponent<GameBoard>().TurnTile(int.Parse(gameObject.name));
        //Debug.Log(gameObject.name);
    }
}
