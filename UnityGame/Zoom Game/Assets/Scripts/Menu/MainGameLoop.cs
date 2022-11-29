using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGameLoop : MonoBehaviour
{
    private Player player;
    private ActionChecker actionChecker;
    void Start()
    {
        player = new Player();
        actionChecker = new ActionChecker();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
