using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private AnimationController _animationController;
    [SerializeField] private CameraHandler _camera;
    [SerializeField] private Mover _mover;

    private void FixedUpdate()
    {
        _animationController.PlayRunAnimation(_inputReader.MoveDirection);
        _mover.Move(_inputReader.MoveDirection);
    }

    private void LateUpdate()
    {

    }
}
