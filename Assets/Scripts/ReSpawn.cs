using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour {


	public GameObject player;
	public Transform spawnPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Ball") 
		{
			player.transform.position = spawnPos.position;
		}
	}
}
