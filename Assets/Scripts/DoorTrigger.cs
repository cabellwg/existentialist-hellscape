using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	public Bell bell;
	public Light roomLight;
	public AudioSource outsideAudio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			Debug.Log ("doortriggered");
			bell.CloseDoor ();
			roomLight.intensity = 8;
			bell.clickCount = 26;
			outsideAudio.Pause ();
			gameObject.SetActive (false);
		}
	}
}
