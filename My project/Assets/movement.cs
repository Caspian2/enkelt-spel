using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float points;
    Rigidbody rb;
    float moveSpeed;
    float jumpForce;
    // Start is called before the first frame update
    void Start()
    {   
        points = 0f;
        rb = GetComponent<Rigidbody>();
        moveSpeed = 0.1f;
        jumpForce = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(moveSpeed, 0 ,0);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(-moveSpeed, 0 ,0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0, 0 ,-moveSpeed);

        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(0, 0, moveSpeed);
        }
    
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Coin")
        {
            points = +1;
            Destroy(other.gameObject);
        }
    }
}
