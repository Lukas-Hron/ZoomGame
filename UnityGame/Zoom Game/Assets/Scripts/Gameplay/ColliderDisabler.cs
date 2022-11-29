using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColliderDisabler : MonoBehaviour
{
    Collider2D _collider;

    void Start()
    {
        _collider = GetComponent<Collider2D>();
    }

    public void OnMouseDown()
    {
        _collider.enabled = false;
    }
}
