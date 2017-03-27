using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSisyphus : MonoBehaviour {

    public GameObject hillTop;
    private GameObject boulder;

    void Start() {
        boulder = GameObject.Find("Sisyphus boulder");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.O)) {
            SceneManager.LoadScene("Room");
        }
    }

    void OnTriggerEnter(Collider other) {
        if (hillTop.GetComponent<HillTopScript>().hasBeenReached && other == boulder.GetComponent<Collider>()) {
            EndScene();
            hillTop.GetComponent<HillTopScript>().hasBeenReached = false;
        }
    }

    private void EndScene() {
        StartCoroutine(FadeLight());
    }

    IEnumerator FadeLight() {
        while (RenderSettings.ambientIntensity >= 0.1f) {
            RenderSettings.ambientIntensity -= 0.04f;
            yield return new WaitForSeconds(0.1f);
        }
        LoadNextScene();
    }

    private void LoadNextScene() {
        SceneManager.LoadScene("Room");
    }

}
