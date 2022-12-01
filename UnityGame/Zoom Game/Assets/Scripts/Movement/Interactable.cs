using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : ZoomLayerObject
{
    private int clickedAmountOfTimes;
    private int maximumInteractionTime;
    public Interactable() : base()
    {
        clickedAmountOfTimes = 0;
        maximumInteractionTime = 1;
    }
    public Interactable(int _maximumInterraction) : base()
    {
        maximumInteractionTime = _maximumInterraction;
    }
    public Interactable(Texture2D texture, Vector2 position, int sortingLayer, GameObject gameObject) : base(texture,position,sortingLayer,gameObject)
    {
        clickedAmountOfTimes = 0;
        maximumInteractionTime = 1;
    }


    public void Click() { 
        if (clickedAmountOfTimes < maximumInteractionTime) {
            clickedAmountOfTimes++;
        }
    }
    public bool allowedMoreInteraction()
    {
        if (clickedAmountOfTimes < maximumInteractionTime) return true;
        else return false;
    }

}
