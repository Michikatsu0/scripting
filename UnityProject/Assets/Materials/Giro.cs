using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    Transform _transform;

    [SerializeField] private Vector3 rotation;
    [SerializeField] private float degreesPerSeconds;

    void Awake()
    {
        Debug.Log("Awake");
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {

        _transform.Rotate(rotation * degreesPerSeconds * Time.deltaTime);
    }
}
