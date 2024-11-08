using UnityEngine;

public class RevolveAroundObject : MonoBehaviour
{

    public Transform centerObject;

    public float distance = 5f;

    float revolutionSpeed = 10f;

    private void FixedUpdate()
    {
        if (centerObject == null)
        {
            Debug.LogWarning("Center object is not set.");
            return;
        }

        float angle = (revolutionSpeed / distance);

        transform.RotateAround(centerObject.position, Vector3.forward, angle);

        Vector3 direction = (transform.position - centerObject.position).normalized;

        transform.position = centerObject.position + direction * distance;

        Vector3 toCenter = centerObject.position - transform.position;
        float angleToCenter = Mathf.Atan2(toCenter.y, toCenter.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angleToCenter - 90); 
    }
}