using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
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