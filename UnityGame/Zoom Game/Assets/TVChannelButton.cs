using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVChannelButton : MonoBehaviour
{
    [SerializeField] bool isRight;
    [SerializeField] float timeToDisableCollider = 1;
    Collider2D col;
    Player player;
    public TVPuzzle tvPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        player = FindObjectOfType<Player>();
    }

    private void OnMouseEnter()
    {
        player.canClick = true;
    }

    private void OnMouseExit()
    {
        player.canClick = false;
    }

    private void OnMouseDown()
    {
        Invoke(methodName: "EnableCollider", timeToDisableCollider);
        col.enabled = false;
        player.canClick = false;
        if (isRight)
        {
            tvPuzzle.NextChannel();
        }
        else
        {
            tvPuzzle.LastChannel();
        }
    }

    public void EnableCollider()
    {
        col.enabled = true;
    }
}

