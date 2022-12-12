using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{

    [SerializeField] private AudioClip _clip;

    private void OnMouseDown()
    {
        AudioHandler.Instance.PlaySoundEffect(_clip);
    }
}
