using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HillTopScript : MonoBehaviour {

    public bool hasBeenReached = false;

    private GameObject boulder;

    void Start() {
        boulder = GameObject.Find("Sisyphus boulder");
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.collider == boulder.GetComponent<Collider>()) {
            hasBeenReached = true;
        }
    }
}
