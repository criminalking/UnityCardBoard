using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public GameObject ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GameObject.Find("BigExplosion");
        ani.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
	    Debug.Log("Point: " + contact.point);
	    double distance = Math.Sqrt(Math.Pow(contact.point[0],2) + Math.Pow(contact.point[1],2));
	    if (distance <= 1.0) // in the yellow area
	    {
                gameObject.SetActive(false); // make the plane disappear
	        ani.SetActive(true);
	    }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
