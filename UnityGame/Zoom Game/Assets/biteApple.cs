using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biteApple : MonoBehaviour
{
    public AudioClip auclip;
    bool hasPlayed;
    Player player;
    public GameObject apple;
    public Sprite bittenApple;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }
    private void OnMouseDown()
    {
        if (!hasPlayed)
        {
            apple.GetComponent<SpriteRenderer>().sprite = bittenApple;
            apple.transform.Rotate(0, 0, 5.0f, Space.Self);
            apple.GetComponent<CircleCollider2D>().enabled = false;
            hasPlayed = true;
            player.canClick = false;
            AudioHandler.Instance.PlaySoundEffect(auclip);
        }
    }
    private void OnMouseEnter()
    {
        if (player.canInteract)
        {
            player.canClick = true;
        }
    }
    private void OnMouseExit()
    {
        player.canClick = false;
    }
}
