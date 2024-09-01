using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class house : MonoBehaviour
{

    private void OnDrawGizmos()
    {
        Vector3 bottomLeft = new Vector3(0, 0, 0);
        Vector3 bottomRight = new Vector3(4, 0, 0);
        Vector3 topLeft = new Vector3(0, 3, 0);
        Vector3 topRight = new Vector3(4, 3, 0);
        Vector3 roofPeak = new Vector3(2, 5, 0); // Peak of the roof

        // Draw the base of the house (rectangle)
        Gizmos.DrawLine(bottomLeft, bottomRight);
        Gizmos.DrawLine(bottomRight, topRight);
        Gizmos.DrawLine(topRight, topLeft);
        Gizmos.DrawLine(topLeft, bottomLeft);

        // Draw the roof (triangle)
        Gizmos.DrawLine(topLeft, roofPeak);
        Gizmos.DrawLine(roofPeak, topRight); ;
    }
    [ContextMenu("Reset Object")]
    private void ResetObject()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            DestroyImmediate(rb);
        }

        transform.position = Vector3.zero;

        transform.rotation = Quaternion.identity;
        transform.localScale = Vector3.one;

    }
}
