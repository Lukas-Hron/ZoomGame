using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseVectorAnimationScrubber : MonoBehaviour
{
    private Animator anim;
    public string animClipName;
    [Range(0.0f, 0.99f)]
    public float normalizedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        anim.Play(animClipName,-1,normalizedTime);
    }
}
