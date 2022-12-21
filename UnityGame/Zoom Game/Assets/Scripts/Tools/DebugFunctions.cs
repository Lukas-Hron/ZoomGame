using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DebugFunctions : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            NarratorPlaylist.Instance.PlayEnding();
            SceneManager.LoadScene(0);
        }
    }
}
