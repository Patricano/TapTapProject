using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonShooting : MonoBehaviour
{
    public GameObject cameraAR;
    public GameObject smoke;

    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(cameraAR.transform.position, cameraAR.transform.forward, out hit))
        {
            Destroy(hit.transform.gameObject);
            Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
        }
    }
}
