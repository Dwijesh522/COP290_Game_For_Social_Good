using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour {
    public bool collided;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if(!collided)
        {
            collided = true;
            GameObject clown = gameObject.transform.parent.gameObject;
            Animator clownAnimator = clown.GetComponent<Animator>();
            clownAnimator.SetTrigger("Hit");
        }
    }
}
