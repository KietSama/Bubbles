using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble2D : MonoBehaviour
{
    public float amplitude;
    public float speed = 1f;

    private Rigidbody2D rigidbody_2D;

    void Start()
    {
        rigidbody_2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 force = Vector3.up * amplitude * Mathf.Sin(speed * Time.time);

        rigidbody_2D.velocity = force;
    }
}
