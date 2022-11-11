using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateController : MonoBehaviour
{
    [Header("éQè∆")]
    [SerializeField]
    private CharacterMovement _characterMovement;

    private CharacterMoveState _currentState;

    private void Start()
    {
        _currentState = CharacterMoveState.OnGround;
    }

    private void Update()
    {
        CharacterUpdate();
    }

    public void ChangeState(CharacterMoveState state)
    {
        ExitState(state);
        EnterState(state);
        _currentState = state;
    }

    private void CharacterUpdate()
    {
        switch (_currentState)
        {
            case CharacterMoveState.OnGround:
                if(_characterMovement != null)
                {
                    _characterMovement.OnUpdate();
                }
                break;
            case CharacterMoveState.Midair:
                break;
        }
    }

    private void EnterState(CharacterMoveState state)
    {
        switch (state)
        {
            case CharacterMoveState.OnGround:
                break;
            case CharacterMoveState.Midair:
                break;
        }
    }

    private void ExitState(CharacterMoveState state)
    {
        switch (state)
        {
            case CharacterMoveState.OnGround:
                break;
            case CharacterMoveState.Midair:
                break;
        }
    }
}

