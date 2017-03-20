using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour {

	public int clickCount;
	public Light roomLight;
	public float lightIntensityReductionBy;

	// Use this for initialization
	void Start () 
	{
		clickCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown()
	{
		if (clickCount < 25) 
		{
			clickCount += 1;
			//make the sound happen
			roomLight.intensity -= lightIntensityReductionBy;
			Debug.Log (clickCount);
		}
		else if (clickCount == 25) 
		{
			//sound happens
			//door opens - some light outside
			//the screams of the damned play loudly
		}

	}
}
