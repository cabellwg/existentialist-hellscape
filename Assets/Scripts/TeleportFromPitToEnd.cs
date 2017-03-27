using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportFromPitToEnd : MonoBehaviour {

    private int i;

    void Start() {
        i = TeleportFromPitToSisyphus.i;
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            if (i == 1) {
                Debug.Log("teleport to sisyphus");
                //teleport to sisyphus
                SceneManager.LoadScene("Game Over");
            }
        }
    }
}
