using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 3;

    float hInput;

    private void Update()
    {
        if (hInput != Input.GetAxisRaw("Horizontal")) 
        {
            hInput = Input.GetAxisRaw("Horizontal");
        }

        if (Input.GetButton("Horizontal")) 
        {
            transform.position += Vector3.right * speed * hInput * Time.deltaTime;
        }
    }
}
