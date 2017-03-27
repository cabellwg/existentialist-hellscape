using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBackToThePit : MonoBehaviour {

    // Use this for initialization
    void Start() {
		
    }
	
    // Update is called once per frame
    void Update() {
		
    }

    void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Debug.Log("sent back to pit");
            //send back to pit
            SceneManager.LoadScene("Staircase");
        }
    }
}
