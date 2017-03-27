using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.ConstrainedExecution;
using UnityEngine.SceneManagement;

public class GameStartSequence : MonoBehaviour {

    public GameObject titleText;
    public Text itQuote;
    public Text engQuote;

    public void RunSequence() {

        TeleportFromPitToSisyphus.i = 0;

        titleText.SetActive(false);

        StartCoroutine(Sequence());
    }

    IEnumerator Sequence() {
        itQuote.gameObject.SetActive(true);
        engQuote.gameObject.SetActive(true);

        engQuote.color = new Color(0f, 0f, 0f, 0f);
        itQuote.color = Color.black;

        yield return new WaitForSeconds(1f);

        while (itQuote.color.r < 1f) {
            itQuote.color += new Color(0.1f, 0.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(3f);

        while (itQuote.color.r > 0f) {
            itQuote.color -= new Color(0.1f, 0.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }

        itQuote.color = new Color(0f, 0f, 0f, 0f);
        engQuote.color = Color.black;

        while (engQuote.color.r < 1f) {
            engQuote.color += new Color(0.1f, 0.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(3f);

        while (engQuote.color.r > 0f) {
            engQuote.color -= new Color(0.1f, 0.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Staircase");
    }

}
