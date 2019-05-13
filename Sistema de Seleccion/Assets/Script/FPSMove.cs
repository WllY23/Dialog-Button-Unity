using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : MonoBehaviour
{
    public float speed=3.0f;

  
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -3, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 3, 0);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
    }
}