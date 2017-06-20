using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float amplitude;
    public float speed = 1f;

    private Rigidbody rigidbody_3D;

    void Start()
    {
        rigidbody_3D = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 force = Vector3.up * amplitude * Mathf.Sin(speed * Time.time);

        rigidbody_3D.velocity = force;
    }
}
