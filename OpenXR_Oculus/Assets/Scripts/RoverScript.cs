using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoverScript : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 moveDirection;
    public float force = 20.0f; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        moveDirection = transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.AddForce(moveDirection * force);
    }
}
