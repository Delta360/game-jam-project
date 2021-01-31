using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockMouse : MonoBehaviour
{
    private void Update()
    {
            //Actives Menu Canvas
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
    }
}
