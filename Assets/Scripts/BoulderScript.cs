using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderScript : MonoBehaviour {

    public GameObject hillTop;
    public GameObject top;

    private int i;

    private Vector3 pos;

    void Start() {
        pos = transform.position;
    }

    void Update() {
        if (hillTop.GetComponent<HillTopScript>().hasBeenReached && i == 0) {
            pos = top.transform.position;
            ResetPosition();
            i++;
        }
    }

    public void ResetPosition() {
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        GetComponent<Rigidbody>().MovePosition(pos);
    }
}
