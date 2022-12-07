using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomLayerObject
{

    private GameObject gameObject;
    private bool[] activated;
    public ZoomLayerObject(GameObject _gameObject)
    {
        gameObject = _gameObject;
        activated = new bool[3];
    }
    public void setGameObject(GameObject _gameObject)
    {
        gameObject = _gameObject;
    }
    public GameObject getGameObject()
    {
        return gameObject;
    }
    public void activate(int i)
    {
    try
        {
            activated[i] = true;
        }
    catch (IndexOutOfRangeException e)
        {
            Debug.Log("" + e.ToString());
        }
    }
    public bool isActivated(int i)
    {
        try
        {
            return activated[i];
        }
        catch (IndexOutOfRangeException e)
        {
            Debug.Log("" + e.ToString());
            return false;
        }
    }
}
