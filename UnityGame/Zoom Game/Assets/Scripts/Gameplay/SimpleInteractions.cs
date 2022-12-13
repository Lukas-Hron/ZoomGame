using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInteractions : MonoBehaviour
{
    Player player;
    Collider2D col;
    Animator anim;

    [Header("Object Properties")]
    [Tooltip("Whether this object can be toggled on and off")]
    [SerializeField] bool isTogglable = false;
    bool isToggled = false;
    [Tooltip("Whether this object should play an animation when interacted with")]
    [SerializeField] bool playAnimation = false;
    [Tooltip("The sound to play when this object is interacted with")]
    [SerializeField] AudioClip soundToPlay;
    [Tooltip("The sound to play when this object is toggled off")]
    [SerializeField] AudioClip soundToPlayToggleOff;
    [Tooltip("The amount of time to wait before re-enabling the object's collider")]
    [SerializeField] float timeToDisableCollider = 1;
    [Tooltip("The type of cursor to display when the player's cursor hovers over this object")]
    enum CursorType { Idle, Pointer, Hand };
    [SerializeField] CursorType cursor;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
        player = FindObjectOfType<Player>();
        if (playAnimation)
        {
            anim = GetComponent<Animator>();
        }

    }

    private void OnMouseEnter()
    {
        switch (cursor)
        {
            case CursorType.Idle:
                //Nothing
                break;
            case CursorType.Pointer:
                player.canClick = true;

                break;
            case CursorType.Hand:
                player.startDragInteract = true;

                break;
            default:
                break;
        }

    }
    private void OnMouseExit()
    {
        switch (cursor)
        {
            case CursorType.Idle:
                //Nothing
                break;
            case CursorType.Pointer:
                player.canClick = false;

                break;
            case CursorType.Hand:
                player.startDragInteract = false;

                break;
            default:
                break;
        }
    }

    private void OnMouseDown()
    {
        col.enabled = false;
        Invoke(methodName: "EnableColliders", timeToDisableCollider);


        if (isTogglable)
        {
            Toggeler();
        }
        else
        {
            if (soundToPlay != null)
                Debug.Log(soundToPlay);
            if (playAnimation)
                anim.SetTrigger("play");
        }



        switch (cursor)
        {
            case CursorType.Idle:
                //Nothing
                break;
            case CursorType.Pointer:
                player.canClick = false;

                break;
            case CursorType.Hand:
                player.startDragInteract = false;

                break;
            default:
                break;
        }
    }

    public void EnableColliders()
    {
        col.enabled = true;
    }

    public void Toggeler()
    {
        isToggled = !isToggled;
        if (isToggled)
        {
            Debug.Log("Toggled On");
            if (playAnimation)
                anim.SetTrigger("on");
            if (soundToPlay != null)
                Debug.Log(soundToPlay);
        }
        else
        {
            Debug.Log("Toggled Off");
            if (playAnimation)
                anim.SetTrigger("off");
            if (soundToPlay != null)
                Debug.Log(soundToPlayToggleOff);
        }
    }
}
