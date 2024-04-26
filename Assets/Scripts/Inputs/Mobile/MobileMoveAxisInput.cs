using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMoveAxisInput : MonoBehaviour, IMoveAxisInput
{
    public Vector2 InputAxis { get; set; }

    public void LeftMoveButtonDown()
    {
        InputAxis = new Vector2(-1, 0);
    }

    public void RightMoveButtonDown()
    {
        InputAxis = new Vector2(1, 0);
    }
}
