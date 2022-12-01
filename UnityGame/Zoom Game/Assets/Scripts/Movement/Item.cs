using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{                                                                                                    // INSTANCE VARIABLES
    private string name;
    private GameObject gameObject;
    private Texture2D texture;
                                                                                                     // CONSTRUCTOR
    public Item()
    {
        name = "empty";
        gameObject = null;
        texture = null;
    }
                                                                                                     // GETTERS & SETTERS
                                                                                                     // GETTERS
    public Texture2D getTexture()
    {
        return texture;
    }
    public GameObject getGameObject()
    {
        return gameObject;
    }
    public string getName()
    {
        return name;
    }

                                                                                                     // SETTERS
    public void setName(string newName)
    {
        name = newName;
    }
    public void setGameObject(GameObject newGameObject)
    {
        gameObject = newGameObject;
    }
    public void setTexture(Texture2D newTexture)
    {
        texture = newTexture;
    }
    
}
