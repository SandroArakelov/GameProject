using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{

    public Rigidbody rb;
    public float speed = 0.1f;
    public float jump = 2f;
    bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(0, jump, 0);
            
        }
    }

    public void OnCollisionEnter(Collision collision) 
    {
         isGrounded = true;
    }

    public void OnCollisionExit(Collision collision) 
    {
        isGrounded = false;    
    }
}
