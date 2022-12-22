using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Linq;

public class DebugFunctions : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the "L" key is pressed
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Find all the objects in the scene that have "Don't Destroy on Load" enabled
            GameObject[] resetObjects = FindObjectsOfType<GameObject>().Where(obj => obj.scene.name != null).ToArray();

            // Destroy all the objects in the list
            foreach (GameObject obj in resetObjects)
            {
                Destroy(obj);
            }

            // Reload the current scene to restart the game
            SceneManager.LoadScene(0);
        }
    }
}

