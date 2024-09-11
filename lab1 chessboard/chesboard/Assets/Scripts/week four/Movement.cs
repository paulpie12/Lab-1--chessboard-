using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }
    }
}
