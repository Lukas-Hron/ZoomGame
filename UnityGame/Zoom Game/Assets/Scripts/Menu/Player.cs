using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private StateMachine.PlayerState currentPlayerState;
    private StateMachine.PlayerState nextPlayerState;
    
    private (float, float) mouseCursorRestriction;

    //                                              DECIMAL     BINARY
    //private bool mouseAllowed;                    //1         0000 0001
    //private bool panningAllowed;                  //2         0000 0010
    //private bool zoomingAllowed;                  //4         0000 0100                   // METOD 1
    //private bool interactionAllowed;              //8         0000 1000
    //private bool inventoryAllowed;                //16        0001 0000
    //private bool constrainedMovement;             //32        0010 0000

    //private bool[] allowedPlayerActions;                                                  // METOD 2

    private uint allowedPlayerActions;                                                     // METOD 3

    public Player()
    {
        currentPlayerState = StateMachine.PlayerState.idle;
        nextPlayerState = StateMachine.PlayerState.idle;
        mouseCursorRestriction = (0.0F, 0.0F);
        allowedPlayerActions = 255;
        }

    // GETTERS & SETTERS

    public void setActionsAllowed(uint newActionsAllowed)
    {
        allowedPlayerActions = allowedPlayerActions & newActionsAllowed;
    }
    public void setCurrentState(StateMachine.PlayerState newState)
    {
        currentPlayerState = newState;
    }
    public void setNextState(StateMachine.PlayerState newState)
    {
        nextPlayerState = newState;
    }
    // FUNCTIONS

    public bool isAllowed(uint allowedMask)
    {
        if ((allowedMask & allowedPlayerActions) > 0) return true;
        else return false;
    }
    
}
