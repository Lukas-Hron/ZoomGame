using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StateMachine
{
   public enum PlayerState { idle, mainMenu, cutscene, panning, zooming, inventory, constrained};
   public enum SceneState { first, second, third, fourth };
   public enum PhaseState { mainMenu, house, cave, endGame };
}
