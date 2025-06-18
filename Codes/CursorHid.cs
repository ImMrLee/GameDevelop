using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ToHideCursor();
    }
    /// <summary>
    /// “˛≤ÿ Û±Í
    /// </summary>
    void ToHideCursor()
    {
        Cursor.visible = false;
    }
    /// <summary>
    /// œ‘ æ Û±Í
    /// </summary>
    void ToShowCursor()
    {
        Cursor.visible = true;
    }
}