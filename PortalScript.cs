using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    //Variables
    public float cooldownTime = 1;
    public bool isReady;
    public GameObject bullet;
    static public GameObject portal_gun;

    //Code

    private void Start()
    {
        portal_gun = gameObject;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !isReady)
        {
            GameObject clone_bullet = Instantiate(bullet, transform.position, Quaternion.identity);
            clone_bullet.AddComponent<BulletScript>();
            StartCoroutine(cooldownTimer());
            isReady = true;
        }

        IEnumerator cooldownTimer()
        {
            yield return new WaitForSeconds(cooldownTime);
            isReady = false;
        }
    }
}
