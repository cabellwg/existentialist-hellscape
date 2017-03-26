using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour {

	public int clickCount;
	public Light roomLight;
	public Light outsideLight;
	public float lightIntensityReductionBy;
	public GameObject door;

	private HingeJoint doorHinge;
	private JointLimits theDoorLimits;
	private JointSpring TheDoorSpring;

	public GameObject doorTrigger;
	public GameObject triggerBackToPit;

	// Use this for initialization
	void Start () 
	{
		triggerBackToPit.SetActive (false);
		clickCount = 0;
		doorHinge = door.GetComponent<HingeJoint> ();
		theDoorLimits = doorHinge.limits;
		TheDoorSpring = doorHinge.spring;

		doorTrigger.SetActive (false);
		CloseDoor ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}	

	void OnMouseDown()
	{
		if (clickCount < 25) {
			DeLight ();
		} else if (clickCount == 25) {
			//sound happens
			doorTrigger.SetActive (true);
			OpenDoor ();
			//the screams of the damned play loudly
		} else if (clickCount > 25 && clickCount < 50) {
			DeLight ();
		} else if (clickCount == 50){
			OpenDoor ();
			outsideLight.intensity = 0;
			triggerBackToPit.SetActive (true);
		}

	}


	public void CloseDoor()
	{
		theDoorLimits.min = 0;
		theDoorLimits.max = 0;
		doorHinge.limits = theDoorLimits;
	}
	public void OpenDoor()
	{
		theDoorLimits.min = -90;
		theDoorLimits.max = 0;
		TheDoorSpring.targetPosition = -90;
		doorHinge.spring = TheDoorSpring;
		doorHinge.limits = theDoorLimits;
	}
	public void DeLight()
	{
		clickCount += 1;
		//make the sound happen
		roomLight.intensity -= lightIntensityReductionBy;
		Debug.Log (clickCount);
	}
}
