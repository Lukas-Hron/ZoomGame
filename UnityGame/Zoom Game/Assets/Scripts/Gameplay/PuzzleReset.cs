using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleReset : MonoBehaviour
{
    GameBoard gameBoard;

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
        gameBoard = GameObject.Find("GridPuzzle").GetComponent<GameBoard>();

        for (int i = 1; i <= 9; i++)
        {
            Tile tile = GameObject.Find(i.ToString()).GetComponent<Tile>();
            if (tile.active)
            {
                gameBoard.ToggleOn(i);
            }
        }
        gameBoard.ToggleOn(1);
        gameBoard.ToggleOn(6);
    }
}
