using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomLayerObject
{                                                                                                      // INSTANCE VARIABLES
    private Texture2D texture;
    private Vector2 position;
    private int sortingLayer;
    private GameObject gameObject;
                                                                                                      // CONSTRUCTORS
    public ZoomLayerObject()
    {
        texture = null;
        position = Vector2.zero;
        sortingLayer = 0;
        gameObject = null;
    }
    public ZoomLayerObject(Texture2D texture, Vector2 position, int sortingLayer, GameObject gameObject)
    {
        this.texture = texture;
        this.position = position;
        this.sortingLayer = sortingLayer;
        this.gameObject = gameObject;
    }
                                                                                                     // GETTERS AND SETTERS
                                                                                                     // GETTERS   
    public Texture2D getTexture()
    {
        return texture;
    }
    public Vector2 getPosition()
    {
        return position;
    }
    public int getSortingLayer()
    {
        return sortingLayer;
    }
    public GameObject getGameObject()
    {
        return gameObject;
    }

                                                                                                    // SETTERS
    public void setTextture(Texture2D newTexture)
    {
        texture = newTexture;
    }
    public void setposition(Vector2 newPosition)
    {
        position = newPosition;
    }
    public void setSortingLayer(int newLayer)
    {
        sortingLayer = newLayer;
    }
    public void setGameObject(GameObject newObject)
    {
        gameObject = newObject;

    }

}
