using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MobileJumpInput : MonoBehaviour, IJumpInput
{
    public event Action Jump;

    public void JumpButtonDown()
    {
        Jump?.Invoke();
    }
}
