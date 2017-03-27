using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public AudioSource bellAudio;
    public AudioSource doorAudio;
    public AudioSource outsideAudio;
    public AudioClip ding;
    public AudioClip doorOpenNoise;
    public AudioClip doorCloseNoise;
    public AudioClip screams;

    // Use this for initialization
    void Start() {
        triggerBackToPit.SetActive(false);
        clickCount = 0;
        doorHinge = door.GetComponent<HingeJoint>();
        theDoorLimits = doorHinge.limits;
        TheDoorSpring = doorHinge.spring;

        doorTrigger.SetActive(false);
        CloseDoor();

        bellAudio.clip = ding;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.O)) {
            SceneManager.LoadScene("Staircase");
        }
    }

    void OnMouseDown() {
        if (clickCount < 25) {
            DeLight();
        } else if (clickCount == 25) {
            doorTrigger.SetActive(true);
            OpenDoor();
            outsideAudio.clip = screams;
            outsideAudio.Play();
        } else if (clickCount > 25 && clickCount < 50) {
            DeLight();
        } else if (clickCount == 50) {
            OpenDoor();
            outsideLight.intensity = 0;
            triggerBackToPit.SetActive(true);
        }

    }


    public void CloseDoor() {
        theDoorLimits.min = 0;
        theDoorLimits.max = 0;
        doorHinge.limits = theDoorLimits;

        doorAudio.clip = doorCloseNoise;
        doorAudio.Play();
    }

    public void OpenDoor() {
        theDoorLimits.min = -90;
        theDoorLimits.max = 0;
        TheDoorSpring.targetPosition = -90;
        doorHinge.spring = TheDoorSpring;
        doorHinge.limits = theDoorLimits;

        doorAudio.clip = doorOpenNoise;
        doorAudio.Play();
    }

    public void DeLight() {
        clickCount += 1;
        bellAudio.Play();
        roomLight.intensity -= lightIntensityReductionBy;
        Debug.Log(clickCount);
    }
}
