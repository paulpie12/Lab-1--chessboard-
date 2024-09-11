using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using static UnityEngine.GraphicsBuffer;

public class revolution : MonoBehaviour
{
    [SerializeField] Transform Center;
    [SerializeField] Transform Enemy;

    void Update()
    {
        float Distance;

        Vector3 dir = Center.position - transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.RotateAround(Center.transform.position, Vector3.forward, 20 * Time.deltaTime);


    }
}
