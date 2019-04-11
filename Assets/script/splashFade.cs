using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class splashFade : MonoBehaviour {
    public Image splashImage;
    public string level;
	// Use this for initialization
    IEnumerator Start()
    {
        PlayerPrefs.SetInt("scoreGigi", 0);
        splashImage.canvasRenderer.SetAlpha(0.0f);
        fadeIn();
        yield return new WaitForSeconds(2.5f);
        fadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("MainMenu");
    }
    void fadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }
    void fadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);
    }
}
