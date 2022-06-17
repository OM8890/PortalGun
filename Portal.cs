using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Variables

//Code
public class Portal : MonoBehaviour
{
    void Update()
    {
        if (PortalGun.portal_count > 2 && tag == "1")
        {
            Destroy(gameObject);
            PortalGun.portal_count -= 1;
        }
        else if (PortalGun.portal_count > 2 && tag == "2")
        {
            Destroy(gameObject);
            PortalGun.portal_count -= 1;
        }
    }
}
