using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biteApple : MonoBehaviour
{
    public AudioClip auclip;
    bool hasPlayed;
    public GameObject apple;
    public Sprite bittenApple;
    private void OnMouseDown()
    {
        if (!hasPlayed)
        {
            apple.GetComponent<SpriteRenderer>().sprite = bittenApple;
            apple.transform.Rotate(0, 0, 5.0f, Space.Self);
            apple.GetComponent<CircleCollider2D>().enabled = false;
            hasPlayed = true;
            AudioHandler.Instance.PlaySoundEffect(auclip);
        }
    }
}
