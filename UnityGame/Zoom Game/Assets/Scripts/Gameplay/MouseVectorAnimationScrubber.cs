using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseVectorAnimationScrubber : MonoBehaviour
{
    public Transform endPoint;
    private Animator anim;
    public string animClipName;
    [Range(0.0f, 0.99f)]
    public float normalizedTime = 0f;
    bool isHolding;
    Vector2 dragVector;
    Vector2 projectedVector;
    Vector3 startPoint;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0;
    }

    void Update()
    {  
        if (isHolding)
        {
            anim.Play(animClipName, -1, normalizedTime);
            if (Input.GetMouseButtonUp(0))
            {
                isHolding = false;
                if (normalizedTime > 0.95) //Complete state
                {
                    normalizedTime = 0.99f;
                    GetComponent<BoxCollider2D>().enabled = false;
                    anim.Play(animClipName, -1, normalizedTime); //snap animation to right position
                    return;
                }
                else //Failed to complete
                {
                    normalizedTime = 0f;
                    anim.Play(animClipName, -1, normalizedTime); //snap animation to begining position
                    return;
                }
            }

            if (!Input.GetMouseButton(1) || !Input.GetMouseButton(3))
            {
                Vector2 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                projectedVector = Vector3.Project(currentMousePos, dragVector);
                normalizedTime = InverseLerp(startPoint, endPoint.position, projectedVector);
                normalizedTime = Mathf.Clamp(normalizedTime, 0f, 0.99f);
            }
        }
    }

    private void OnMouseDown()
    {
        startPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isHolding = true;
        dragVector = endPoint.position - startPoint;

    }
    public static float InverseLerp(Vector2 a, Vector2 b, Vector2 value) 
    {
        Vector2 AB = b - a;
        Vector2 AV = value - a;
        return Vector2.Dot(AV, AB) / Vector2.Dot(AB, AB);
    }
}
