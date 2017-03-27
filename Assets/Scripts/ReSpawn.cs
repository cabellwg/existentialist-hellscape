using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReSpawn : MonoBehaviour {


    public GameObject player;
    public Transform spawnPos;
    // Use this for initialization
    void Start() {
		
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.O)) {
            SceneManager.LoadScene("Sisyphus");
        } else if (Input.GetKeyDown(KeyCode.I)) {
            SceneManager.LoadScene("Game Over");
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Ball") {
            player.transform.position = spawnPos.position;
        }
    }
}
