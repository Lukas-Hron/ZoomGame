using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleReset : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (gameObject.name == "Reset")
        {
            ResetPuzzle();
        }
        else
        {
            return;
        }
    }
    public void ResetPuzzle()
    {
        for (int i = 1; i <= 9; i++)
        {
            Tile tile = GameObject.Find(i.ToString()).GetComponent<Tile>();
            if (tile.active)
            {
                GameObject.Find("GridPuzzle").GetComponent<GameBoard>().ToggleOn(i);
            }
        }
        GameObject.Find("GridPuzzle").GetComponent<GameBoard>().ToggleOn(1);
        GameObject.Find("GridPuzzle").GetComponent<GameBoard>().ToggleOn(3);
    }
}
