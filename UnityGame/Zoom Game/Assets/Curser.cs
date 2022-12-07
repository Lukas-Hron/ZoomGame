using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curser : MonoBehaviour
{
    public Player player;
    SpriteRenderer sprn;
    public List<Sprite> cursers;
    int currentCurser;
    int lastframeCurser;

    private void Start()
    {
        sprn = GetComponent<SpriteRenderer>();
        Debug.Log(cursers.Count);
        sprn.sprite = cursers[0];
        
    }


    private void Update()
    {
        transform.parent.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        currentCurser = 0;
        if (player.isZooming)
        {
            currentCurser = 1;
        }

        if (player.isPanning)
        {
            currentCurser = 2;
        }

        if(lastframeCurser != currentCurser)
        {
        sprn.sprite = cursers[currentCurser];
            Debug.Log("changed");
        }

        lastframeCurser = currentCurser;
    }
}
