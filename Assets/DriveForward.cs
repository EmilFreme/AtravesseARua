using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class DriveForward : MonoBehaviour
{
    private Rigidbody rb;
    private BoxCollider bc;

    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
        bc = GetComponent<BoxCollider>();
        speed = Random.Range(10, 20);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = new Vector3(speed, rb.velocity.y, rb.velocity.z);
        rb.velocity = vel; 
    }
}
