using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [Header("パラメーター")]
    [SerializeField]
    private float _moveSpeed = 5;
    [Header("参照")]
    [SerializeField]
    private Rigidbody2D _rb;
    [SerializeField]
    private InputDirection _inputDirection;

    public void OnUpdate()
    {
        switch (_inputDirection.CurrentDirection)
        {
            case Direction.NEUTRAL:
                Neutral();
                break;
            case Direction.RIGHT:
                RightMove();
                break;
            case Direction.LEFT:
                LeftMove();
                break;
        }
    }

    private void Neutral()
    {
        _rb.velocity = Vector2.zero;
        _rb.angularVelocity = 0;
    }

    private void RightMove()
    {
        _rb.velocity = _moveSpeed * Vector2.right;
    }

    private void LeftMove()
    {
        _rb.velocity = _moveSpeed * Vector2.left;
    }
}
