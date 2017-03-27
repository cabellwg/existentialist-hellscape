using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextFadeIn : MonoBehaviour {

    private Text quote;

    void Start() {
        quote = gameObject.GetComponent<Text>();
        StartCoroutine(Fade());
    }

    IEnumerator Fade() {
        quote.color = Color.black;

        yield return new WaitForSeconds(1f);

        while (quote.color.r < 1f) {
            quote.color += new Color(0.1f, 0.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(3f);

        while (quote.color.r > 0f) {
            quote.color -= new Color(0.1f, 0.1f, 0.1f);
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("Start");
    }
}
