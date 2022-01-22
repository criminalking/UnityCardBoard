using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public BallPrefab ballPrefab;
    public GameObject plane;
    
    // Use this for initialization
    void Start()
    {
        plane = GameObject.Find("Plane");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
	{
	    BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);
	    ball.transform.localPosition = transform.position;
	    
	    ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(1300, 1350));
	}
    }
}
