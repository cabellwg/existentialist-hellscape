using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportFromPitToSisyphus : MonoBehaviour {

    public static int i = 0;



    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Player")) {
            if (i == 0) {
                i++;
                Debug.Log("teleport to sisyphus");
                //teleport to sisyphus
                SceneManager.LoadScene("Sisyphus");
            }
        }
    }
}
