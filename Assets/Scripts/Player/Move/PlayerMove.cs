using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    [field: SerializeField] public float CurrentSpeed { get; set; }
    [SerializeField] private float _defaultSpeed;
    [SerializeField] private PlayerInputs _inputs;

    private CompositeDisposable _disposable = new CompositeDisposable();
    private Rigidbody2D _rigidbody;

    private void Awake()
        => _rigidbody = GetComponent<Rigidbody2D>();

    private void Start()
        => CurrentSpeed = _defaultSpeed;

    private void OnEnable()
    {
        Observable.EveryFixedUpdate().Subscribe(_ =>
        {
            _rigidbody.velocity = new Vector2(_inputs.MoveAxisInput.InputAxis.x * CurrentSpeed * Time.deltaTime,
                _rigidbody.velocity.y);
        }).AddTo(_disposable);
    }

    private void OnDisable()
        => _disposable.Clear();
}