using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] private Vector3 _axis;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_axis, _speed * Time.deltaTime);
    }
}
