using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionChecker : MonoBehaviour
{
    private uint actionsAllowed;
    private StateMachine.PhaseState currentPhaseState;
    private StateMachine.SceneState currentSceneState;
    private StateMachine.PlayerState currentPlayerState;

    public ActionChecker()
    {
        uint actionsAllowed = 0;
        currentPhaseState = StateMachine.PhaseState.mainMenu;
        currentSceneState = StateMachine.SceneState.first;
        currentPlayerState = StateMachine.PlayerState.idle;
    }
    public ActionChecker(uint actionsAllowed, StateMachine.PhaseState currentPhaseState, StateMachine.SceneState currentSceneState, StateMachine.PlayerState currentPlayerState)
    {
        currentPhaseState = StateMachine.PhaseState.mainMenu;
        currentSceneState = StateMachine.SceneState.first;
        currentPlayerState = StateMachine.PlayerState.idle;
        this.actionsAllowed = actionsAllowed;
        this.currentPhaseState = currentPhaseState;
        this.currentSceneState = currentSceneState;
        this.currentPlayerState = currentPlayerState;
    }

    public void CheckAction(StateMachine.PhaseState phaseState, StateMachine.SceneState sceneState, StateMachine.PlayerState playerState)
    {
        switch(phaseState) {
            case (StateMachine.PhaseState.mainMenu):
                 mainMenuCheckAction(sceneState, playerState);
                
            break;

            case (StateMachine.PhaseState.house):
                 houseCheckAction(sceneState, playerState);   
            break;
        }
    }
     // MAIN MENU STATES:
     // FIRST = MAIN MENU
     // SECOND = CUTSCENE
     
    private void mainMenuCheckAction(StateMachine.SceneState sceneState, StateMachine.PlayerState playerState)
    {
        switch (sceneState)
        {
            case (StateMachine.SceneState.first):                   // MAIN MENU
                    // CHECK IF PLAYER IS ATEMPTING TO CLICK A MENU ITEM!
                    // IF SO DISABLE EVERYTHING
                    // SET NEW SCENE = CUTSCENE                                           ???  ENABLE THROUGH STATIC OR PASSED THROUGH!!!!!!!!!!!!!!!!!!
                    break;

            case (StateMachine.SceneState.second):
                // CHECK IF CUTSCENE DONE?
                // IF SO NEXT PHASE = 

                break;
 
        }
   
    }
    private void houseCheckAction(StateMachine.SceneState sceneState, StateMachine.PlayerState playerState)
    {

    }
}
