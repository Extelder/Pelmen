using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopJumpInput : MonoBehaviour, IJumpInput
{
    [SerializeField] public KeyCode Key = KeyCode.Space;
    public event Action Jump;

    private void Update()
    {
        if (Input.GetKeyDown(Key))
        {
            Jump?.Invoke();
        }
    }
}