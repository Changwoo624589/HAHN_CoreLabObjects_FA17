using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

    AudioSource myAudio;

    float num;
    

	// Use this for initialization
	void Start () {

        num = 5;
        myAudio = GetComponent<AudioSource>();


	}
    //the moment when collusion happen
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter");

        myAudio.Play();
        Debug.Log(myAudio);
       // if (myAudio.isPlaying)
       // {
       //    Debug.Log("Tes It's Playing");

        //}
        //if myAudio is not playing
          //myAudio.is Playing == false

        // run myAuidio.Play();
        if ( myAudio.isPlaying == false)
        {

            myAudio.Play();
        }

    }

    //lasts for a while
    void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Stay");
    }

    //the moment no collision
    void OnCollisionExit(Collision collision) { 
        Debug.Log("Exit");
    }

}
