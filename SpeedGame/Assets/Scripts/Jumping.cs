using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script just to test start prototype
public class Jumping : MonoBehaviour
{
    //public variables
    public float jumpForce = 1f;
    public float moveSpeed = 0.25f;

    //private variables
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * jumpForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * jumpForce * Time.deltaTime);
        }
    }
}
