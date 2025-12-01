using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Timeline.TimelinePlaybackControls;

[RequireComponent(typeof(PlayerInput))]
public class InputReader : MonoBehaviour
{
    private PlayerInput _playerInput;

    private Vector3 _lookDirection;
    private Vector3 _moveDirection;

    public Vector3 MoveDirection => _moveDirection;
    public Vector3 LookDirection => _lookDirection;

    private void Awake()
    {
        _playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        _lookDirection = _playerInput.Player.Look.ReadValue<Vector2>();
        _moveDirection = _playerInput.Player.Move.ReadValue<Vector2>();
    }

    private void OnShoot(InputAction.CallbackContext context)
    {
        
    }
}
