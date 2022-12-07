using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor
{
    private Texture2D cursorTexture;
    private CursorMode cursorMode;           // Hardware cursors
    private Vector2 clickPoint;

    public MouseCursor()
    {
        cursorTexture = null;
        cursorMode = CursorMode.ForceSoftware;
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
    /// <summary>
    /// cursorNumbers: 0-default, 1-panning, 2-zooming, 3-dragInteract
    /// </summary>
    /// <param name="cursorNumber"></param>
    public void changeCursor(int cursorNumber)
    {
        var texturen = Texture2D.whiteTexture;
        switch (cursorNumber)
        {
            case 0:
                texturen = Resources.Load<Texture2D>("Art/MouseCursors/mouseCursorDefault");
                break;
            case 1:
                texturen = Resources.Load<Texture2D>("Art/MouseCursors/mouseCursorPanning");
                break;
            case 2:
                break;
            case 3:
                break;

        }
        this.changeCursorTexture(texturen);
        Cursor.SetCursor(cursorTexture, clickPoint, cursorMode);
    }

}