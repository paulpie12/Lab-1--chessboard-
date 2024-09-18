using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CinemachineImpulseSource))]
public class Player : MonoBehaviour
{
    private CinemachineImpulseSource cinemachineImpulse;

    public GameObject laserPrefab;

    private float horizontalScreenLimit = 10f;
    private float verticalScreenLimit = 6f;
    private bool canShoot = true;



    // Update is called once per frame
    void Update()
    {
 
        Shooting();
    }

 
    private void Start()
    {
        cinemachineImpulse = GetComponent<CinemachineImpulseSource>();
    }
    private void ApplyShootFireEffect()
    {
        cinemachineImpulse.GenerateImpulse();
    }



public void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
            Instantiate(laserPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
            ApplyShootFireEffect();
            canShoot = false;
            StartCoroutine("Cooldown");
        }
    }

    private IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(1f);
        canShoot = true;
    }
}
