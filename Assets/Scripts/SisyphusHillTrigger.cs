using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SisyphusHillTrigger : MonoBehaviour {

    public GameObject hillTop;
    private GameObject boulder;

    void Start() {
        boulder = GameObject.Find("Sisyphus boulder");
    }

    void OnTriggerEnter(Collider other) {
        if (gameObject.name == "Ground" && hillTop.GetComponent<HillTopScript>().hasBeenReached == false) {
            return;
        } else if (other = boulder.GetComponent<Collider>()) {
            boulder.GetComponent<BoulderScript>().ResetPosition();
        }
    }

}
