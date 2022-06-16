using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //Variables
    float bullet_speed = 40f;

    //Code
    void Update()
    {
        transform.position += PortalScript.portal_gun.transform.forward * Time.deltaTime * bullet_speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag != "Portal Gun")
        {
            Destroy(gameObject);
        }
    }
}
