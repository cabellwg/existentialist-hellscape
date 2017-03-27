using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitBallSpawner : MonoBehaviour {

	public GameObject ball;
	public Transform spawn;
	public float ballSpawnDelay = 3.0f;

	// Use this for initialization
	void Start () 

	{
		InvokeRepeating ("SpawnBall", 1.0f, ballSpawnDelay);
	}
	
	// Update is called once per frame
	void Update () {
	}



	void SpawnBall()
	{
		GameObject Instance = Instantiate (ball, spawn.position, Quaternion.identity) as GameObject;
	}
}
