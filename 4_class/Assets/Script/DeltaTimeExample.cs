using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTimeExample : MonoBehaviour {

    //distance, spped, time
    //distance = speed * time
    //Time.deltaTime (second) - constantly check unity documentation
    //speed: 5 (meter/second);
    //distance = 5 * Time.deltaTime;

    public float speed = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float distanced = 5 * Time.deltaTime;

        transform.Translate(5 * Time.deltaTime, 0, 0);

        

	}
}
