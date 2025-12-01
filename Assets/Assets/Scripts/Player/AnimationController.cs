using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string ForwardSpeed = nameof(ForwardSpeed);
    private const string SideSpeed = nameof(SideSpeed);

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayRunAnimation(Vector2 direction)
    {
        _animator.SetFloat(ForwardSpeed, direction.y);
        _animator.SetFloat(SideSpeed, direction.x);
    }
}
