using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem
{
    private string name;
    private GameObject gameObject;

    public PlayerItem(string _name, GameObject _gameObject)
    {
        name = _name;
        gameObject = _gameObject;
    }
    public void setGameObject(GameObject _gameObject)
    {
        gameObject = _gameObject;
    }
    public string getName()
    {
        return name;
    }
    public GameObject getGameObject()
    {
        return gameObject;
    }
}
