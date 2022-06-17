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
        transform.position += PortalGun.portal_gun.transform.forward * Time.deltaTime * bullet_speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag != "Portal Gun")
        {
            Destroy(gameObject);
        }
        PortalGun.portal_count += 1;
        GameObject portal_clone = Instantiate(PortalGun.portal_static, transform.position, Quaternion.identity);
    }
}
