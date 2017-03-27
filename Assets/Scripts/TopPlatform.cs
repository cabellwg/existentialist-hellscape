using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlatform : MonoBehaviour {

    public GameObject teleportToSisyphus;

    // Use this for initialization
    void Start() {
        teleportToSisyphus.SetActive(false);
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            teleportToSisyphus.SetActive(true);
            //UI that shows jump back down
            Debug.Log("jump back down fool");
            GameObject.Find("Text").SetActive(true);
        }
    }
}
