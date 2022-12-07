using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem
{
    private string name;
    private Texture2D texture;

    public PlayerItem(string _name, Texture2D _gameObject)
    {
        name = _name;
        texture = _gameObject;
    }
    public void setTexture(Texture2D _gameObject)
    {
        texture = _gameObject;
    }
    public string getName()
    {
        return name;
    }
    public Texture2D getTexture()
    {
        return texture;
    }
}
