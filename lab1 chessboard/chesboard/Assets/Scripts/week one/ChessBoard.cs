using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        float x = 1;
        float y = 1;
        int counter = 0;
        Vector3 gizmoSize = new Vector3(1f, 1f, 1f);

        while (counter < 8)
        {
            for (int i = 0; i < 4; i++)
            {
                Gizmos.color = Color.white;
                Gizmos.DrawWireCube(new Vector3(x, y, 1f), gizmoSize);
                x = x + 1.01f;
                Gizmos.color = Color.black;
                Gizmos.DrawWireCube(new Vector3(x, y, 1f), gizmoSize);
                x = x + 1.01f;
            }
            y = y + 1.01f;
            counter++;
            x = 1;
            for (int i = 0; i < 4; i++)
            {
                Gizmos.color = Color.black;
                Gizmos.DrawWireCube(new Vector3(x, y, 1f), gizmoSize);
                x = x + 1.01f;
                Gizmos.color = Color.white;
                Gizmos.DrawWireCube(new Vector3(x, y, 1f), gizmoSize);
                x = x + 1.01f;
            }
            y = y + 1.01f;
            counter++;
            x = 1;
        }
    }
}
