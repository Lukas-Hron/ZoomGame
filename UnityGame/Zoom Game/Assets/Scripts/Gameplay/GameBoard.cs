using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public Sprite tileOn;
    public Sprite tileOff;
    public int columns = 3;
    public int rows = 3;
    public int tileAmount;

    private void Start()
    {
        //calculate tiles in on gameboard
        tileAmount = columns * rows;
        //preset puzzle change which tiles starts active
        ToggleOn(1);
        ToggleOn(6);
    }
    private void ChangeSprite(SpriteRenderer tileSpriteRenderer, Sprite newSprite)
    {
        tileSpriteRenderer.sprite = newSprite;
    }
    public void OnMouseDown()
    {
        //When clicking on the gameobj tile, turn the tile name to int and send to TurnTile function
        TurnTile(int.Parse(gameObject.name));
        //Debug.Log(gameObject.name);

    }

    public void TurnTile(int name)
    {
        //Toggles the tile you click on (its own number)
        ToggleOn(name);
        //Toggles the tile below
        ToggleOn(name + columns);
        //Toggles the tile above
        ToggleOn(name - columns);

        //Stops tile 3 from turning tile 4
        if(name%columns != 0)
            ToggleOn(name+1);
        //Stops tile 7 from turning tile 6
        if(name%columns != 1)
            ToggleOn(name-1);
    }

    public void ToggleOn(int name)
    {
        //Only run when the tile exists (1-9)
        if (name < 1 || name > 9) return;

        //Reference Tile from tile class to toggle targeted tiles active bool
        Tile tile= GameObject.Find(name.ToString()).GetComponent<Tile>();
        tile.ToggleActive();

        //Sets to active or inactive sprite (On/Off)
        if (tile.active)
            ChangeSprite(tile.GetComponent<SpriteRenderer>(), tileOn);
        else
            ChangeSprite(tile.GetComponent<SpriteRenderer>(), tileOff);
    }
}
