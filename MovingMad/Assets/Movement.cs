using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
    
{
    Rigidbody rigidbody;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
       
            transform.position += (Vector3.left * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {

            transform.position += (Vector3.right * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.W))
        {

            transform.position += (Vector3.up * speed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {

            transform.position += (Vector3.down * speed) * Time.deltaTime;
        }
    }
}
