using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHid : MonoBehaviour
{
    void Start()
    {
        ToHideCursor();
    }
    void ToHideCursor()
    {
        Cursor.visible = false;
    }
    void ToShowCursor()
    {
        Cursor.visible = true;
    }
}