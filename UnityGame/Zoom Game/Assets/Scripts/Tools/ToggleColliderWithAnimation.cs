using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleColliderWithAnimation : MonoBehaviour
{
    public List<Collider2D> collidersSelf;
    public List<Collider2D> collidersOther;
    // Start is called before the first frame update


    public void TurnOnColliders(string list)
    {
        if (list == "self")
        {
            foreach (Collider2D col in collidersSelf)
            {
                col.enabled = true;
            }
        }
        else
        {
            foreach (Collider2D col in collidersOther)
            {
                col.enabled = true;
            }
        }
 
    }

    public void TurnOffColliders(string list)
    {
        if (list == "self")
        {
            foreach (Collider2D col in collidersSelf)
            {
                col.enabled = false;
            }
        }
        else
        {
            foreach (Collider2D col in collidersOther)
            {
                col.enabled = false;
            }
        }

    }
}
