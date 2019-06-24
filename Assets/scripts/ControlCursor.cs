using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCursor : MonoBehaviour
{
    public void SetCursor(bool show)
    {
        Cursor.lockState = show ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = show;
    }

}
