using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float forceMultiplier = 3f;
    public float maximumVelocity = 3f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //var horizontalInput = Input.GetAxis("Horizontal");
        //if (GetComponent<Rigidbody>().velocity.magnitude <= maximumVelocity)
        //{
        //    GetComponent<Rigidbody>().AddForce(new Vector3(horizontalInput * forceMultiplier, 0, 0));
        //}

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 500);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * 500);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * 500);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.up * 500);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(gameObject);
        }
    }
}