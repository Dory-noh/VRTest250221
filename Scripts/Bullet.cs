using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 3000f;
    public Rigidbody rb;
    public TrailRenderer trail;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
        Destroy(gameObject, 3f);
    }

    void Update()
    {
        
    }
}
