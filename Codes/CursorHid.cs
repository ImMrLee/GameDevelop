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
    /// �������
    /// </summary>
    void ToHideCursor()
    {
        Cursor.visible = false;
    }
    /// <summary>
    /// ��ʾ���
    /// </summary>
    void ToShowCursor()
    {
        Cursor.visible = true;
    }
}