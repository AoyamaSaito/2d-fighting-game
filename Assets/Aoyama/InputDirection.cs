using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputDirection : MonoBehaviour
{
    private Vector3 _move;

    private Direction _currentDirection;
    public Direction CurrentDirection => _currentDirection;

    static readonly Direction[,] sDirTable = {
                    { Direction.LEFT_DOWN, Direction.DOWN, Direction.RIGHT_DOWN },
                    { Direction.LEFT, Direction.NEUTRAL, Direction.RIGHT },
                    { Direction.LEFT_UP, Direction.UP, Direction.RIGHT_UP }
                };

    public void OnMove(InputAction.CallbackContext context)
    {
        _move = context.ReadValue<Vector2>();
        _currentDirection = Get4Direction(_move);
    }

    public Direction Get4Direction(Vector2 direction)
    {
        const float MaxScale = 1.0f;
        int bx = (int)Mathf.Round(direction.x / MaxScale) + 1;
        int by = (int)Mathf.Round(direction.y / MaxScale) + 1;
        return sDirTable[by, bx];
    }
}
