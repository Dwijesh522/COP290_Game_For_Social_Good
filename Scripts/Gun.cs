using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject bulletPrefab;
    public Transform launchPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Fire1") == 1.0f)
        {
            if(!IsInvoking("FireBullet"))
            {
                InvokeRepeating("FireBullet", 0.0f, 0.1f);
            }
        }

        if(Input.GetAxis("Fire1") != (1.0f))
        {
            CancelInvoke("FireBullet");
        }
	}

    void FireBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab) as GameObject;
        bullet.transform.position = launchPosition.position;
        bullet.GetComponent<Rigidbody>().velocity = transform.parent.forward * 100;
    }
}
