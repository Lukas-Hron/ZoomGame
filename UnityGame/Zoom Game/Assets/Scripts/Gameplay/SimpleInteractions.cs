using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInteractions : MonoBehaviour
{
    Player player;
    public Collider2D onCollider, offCollider;
    Animator anim;

    [Header("Object Properties")]
    [Tooltip("Whether this object can be toggled on and off")]
    [SerializeField] bool isTogglable = false;
    bool isToggled = false;
    [Tooltip("Whether this object should play an animation when interacted with")]
    [SerializeField] bool playAnimation;
    [Tooltip("Whether this object should play sounds in random order")]
    [SerializeField] bool randomizeSound;
    [Tooltip("List of sounds to ranomize from")]
    [SerializeField] List<AudioClip> listOfSounds;
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

        if (randomizeSound)
            RandomizeSoundToPlay();

        if (isTogglable)
        {
            onCollider.enabled = false;
            offCollider.enabled = false;
            Toggeler();
        }
        else
        {
            onCollider.enabled = false;
            if (soundToPlay != null)
                AudioHandler.Instance.PlaySoundEffect(soundToPlay);
            if (playAnimation)
                anim.SetTrigger("play");
        }

        Invoke(methodName: "EnableColliders", timeToDisableCollider);

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
        if (isTogglable)
        {
            if (isToggled)
            {
                onCollider.enabled = true;
            }
            else
            {
                offCollider.enabled = true;
            }

        }
        else
        onCollider.enabled = true;
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
                AudioHandler.Instance.PlaySoundEffect(soundToPlay);
        }
        else
        {

            Debug.Log("Toggled Off");
            if (playAnimation)
                anim.SetTrigger("off");
            if (soundToPlay != null)
                AudioHandler.Instance.PlaySoundEffect(soundToPlayToggleOff);
        }
    }
    private void RandomizeSoundToPlay()
    {
        int randomIndex = Random.Range(0, listOfSounds.Count);
        AudioClip clip = listOfSounds[randomIndex];
        AudioHandler.Instance.PlaySoundEffect(clip);
    }
}
