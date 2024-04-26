using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private PlayerInputs _inputs;
    [SerializeField] private PlayerGround _ground;

    private Rigidbody2D _rigidbody;

    private void Awake()
        => _rigidbody = GetComponent<Rigidbody2D>();

    private void OnEnable()
        => _inputs.JumpInput.Jump += Jump;

    private void OnDisable()
        => _inputs.JumpInput.Jump -= Jump;

    private void Jump()
    {
        if (_ground.OnGround.Value)
        {
            _rigidbody.AddForce(Vector3.up * _force, ForceMode2D.Impulse);
        }
    }
}