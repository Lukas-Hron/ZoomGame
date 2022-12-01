using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCursor
{
    private Texture2D cursorTexture;
    private CursorMode cursorMode;           // Hardware cursors
    private Vector2 clickPoint;
    
    public mouseCursor()
    {
        cursorTexture = null;
        cursorMode = CursorMode.Auto;
        clickPoint = Vector2.zero;
    }

    public void updateCursor()
    {
        Cursor.SetCursor(cursorTexture, clickPoint, cursorMode);
    }
    public void changeClickPoint(float offsetX, float offsetY)
    {
        clickPoint = new Vector2(offsetX, offsetY);
        Cursor.SetCursor(cursorTexture, clickPoint, cursorMode);
    }
    public void changeCursorTexture(Texture2D newCursorTexture)
    {
        cursorTexture = newCursorTexture;
        Cursor.SetCursor(cursorTexture, clickPoint, cursorMode);
    }
    
}
