using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
  private StateMachine.PlayerState currentState;
  private PlayerItem[] inventory;
    private MouseCursor mouseCursor;

    public Player()
    {
        currentState = StateMachine.PlayerState.mainMenu;
        inventory = new PlayerItem[5];
        mouseCursor = new MouseCursor();
    }
    public void setNewState(StateMachine.PlayerState newState)
    {
        currentState = newState;
        updateMouseCursor();
    }
    
    public void setInventory(PlayerItem[] newInventory)
    {
        inventory = newInventory;
    }
    public StateMachine.PlayerState getCurrentState()
    {
        return currentState;
    }
    public PlayerItem[] getInventory()
    {
        return inventory;
    }
    public MouseCursor getMouseCursor()
    {
        return mouseCursor;
    }
    public void updateMouseCursor()
    {
        switch (currentState)
        {
            case StateMachine.PlayerState.idle:
                 mouseCursor.changeCursor(0);
                 break;

            case StateMachine.PlayerState.panning:
                mouseCursor.changeCursor(1);
                break;

            case StateMachine.PlayerState.cutscene:
                break;

            case StateMachine.PlayerState.dragInteract:
                break;

            case StateMachine.PlayerState.zooming:
                mouseCursor.changeCursor(2);
                break;
        }
    }
}
