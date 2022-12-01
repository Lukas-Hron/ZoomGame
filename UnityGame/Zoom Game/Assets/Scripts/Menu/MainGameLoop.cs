using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameLoop : MonoBehaviour
{
    // PLAYER & INVENTORY
    private Player player;
    private Inventory inventory;

    // UI
    private mouseCursor mouseCursor;
    private ActionChecker actionChecker;

    //PHASES
    
    void Start()
    {
        player = new Player();
        actionChecker = new ActionChecker();
        inventory = new Inventory();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
