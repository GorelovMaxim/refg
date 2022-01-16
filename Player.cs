using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private Joystick _joystick;

    [SerializeField]
    private float _speed;

    private Rigidbody2D _rigidbody2D;
    private Vector2 _direction;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _direction = _joystick.Direction;
        if (Mathf.Abs(_direction.x) > 5f) _direction.x /= 2;
        if (Mathf.Abs(_direction.y) > .5f) _direction.y /= 2;
        _rigidbody2D.velocity = _direction * _speed;
        print(_rigidbody2D.velocity);
    }
    
}
