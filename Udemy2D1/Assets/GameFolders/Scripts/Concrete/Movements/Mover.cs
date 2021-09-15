using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Mover : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] DirectionEnum direction;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void OnEnable()
    {
        _rigidbody2D.velocity = SelectedNewDirection() * moveSpeed;
    }
    private Vector2 SelectedNewDirection()
    {
        Vector2 selectedDirection;

        if (direction == DirectionEnum.Left)
        {
            selectedDirection = Vector2.left;
        }
        else
        {
            selectedDirection = Vector2.right;
        }
        return selectedDirection;
    }
}
