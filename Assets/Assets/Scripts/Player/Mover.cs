using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public void Move(Vector3 direction)
    {
        Vector3 tempDirection = new Vector3(direction.x, 0, direction.y);

        transform.Translate(tempDirection * Time.deltaTime * _speed);
    }
}
