using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Linq;
using UnityEngine.Rendering.PostProcessing;

public class DebugFunctions : MonoBehaviour
{
    public PostProcessVolume postpro;
    private LensDistortion lens;
    bool drunkmode;
    // Update is called once per frame

    private void Start()
    {
        postpro.profile.TryGetSettings(out lens);
    }
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

        if (Input.GetKeyDown(KeyCode.M))
        {
            drunkmode = !drunkmode;

            if (drunkmode)
            {
                lens.intensity.value = -100f;
                lens.scale.value = 1.87f;
            }
            else
            {
                lens.intensity.value = -20f;
                lens.scale.value = 1f;
            }

        }

    }
}

