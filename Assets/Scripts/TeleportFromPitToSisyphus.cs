using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportFromPitToSisyphus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			Debug.Log ("teleport to sisyphus");
			//teleport to sisyphus
		}
	}
}
