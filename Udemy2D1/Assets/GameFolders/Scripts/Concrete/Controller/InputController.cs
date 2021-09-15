using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController
{
    public bool LeftMouseClickDown => Input.GetMouseButtonDown(0);
    public bool RightMouseClickDown => Input.GetMouseButtonDown(1);
}
