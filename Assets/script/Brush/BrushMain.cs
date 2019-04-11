using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BrushMain : MonoBehaviour {

    private IEnumerator coroutine;

    float waitTime = 2;
    public Timer timerClass;

    private float brushingTime;
    private float timeCounter;

    Brushing brush;

    Teeth[] tooth;

    public Text calculusText;
    public Text scoreText;
    public Text StageTime;


    void Awake()
    {
        tooth = FindObjectsOfType<Teeth>();
        brush = FindObjectOfType<Brushing>();
    }

    void Start()
    {
        coroutine = startBrush();
        StartCoroutine(coroutine);
        brushingTime = timerClass.getTime;
        StageTime.text = "" + brushingTime;
    }

    void Update()
    {
        if (timeCounter > 0 && Brushing.Calculus > 0)
        {
            timeCounter -= Time.deltaTime;
            StageTime.text = "" + (int)timeCounter;
        }
        if (Brushing.Calculus == 0)
        {
            PlayerPrefs.SetInt("scoreGigi", Brushing.score);
            brush.GetComponent<DragHandler>().enabled = false;
            SceneManager.LoadScene("level1");
        }
        calculusText.text = "Calculus : " + Brushing.Calculus;
        scoreText.text = "Score : " + Brushing.score;
    }

    public void UpdateCal()
    {
        Brushing.Calculus = 0;
        int cal = 0;
        foreach (Teeth t in tooth)
        {
            cal += t.calculus;
        }
        Brushing.Calculus = cal;

    }
    public Image splas;
    public Image dt;
    private IEnumerator startBrush()
    {
        splas.canvasRenderer.SetAlpha(1f);
        dt.canvasRenderer.SetAlpha(0f);
        splas.CrossFadeAlpha(0.0f, 1.5f, false);
        // display count down
        print("display count down");
        UpdateCal();
        yield return new WaitForSeconds(waitTime);
        // turn off display count down
        print("turn off display count down");
        // start brushing
        print("start brushing");
        brush.GetComponent<DragHandler>().enabled = true;
        timeCounter = brushingTime;
        print(timeCounter);
        if (Brushing.Calculus == 0)
        {
            PlayerPrefs.SetInt("scoreGigi", Brushing.score);
            brush.GetComponent<DragHandler>().enabled = false;
            splas.CrossFadeAlpha(1f, 2f, false);
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene("level1");
        }
        yield return new WaitForSeconds(timeCounter);
        //yield return new WaitWhile(() => Brushing.Calculus != 0);
        //yield return new WaitUntil(() => timeCounter == 0);
        print(timeCounter);
        // display brushing time is over
        print("brushing over");
        if (Brushing.Calculus != 0)
        {
            brush.GetComponent<DragHandler>().enabled = false;
            dt.CrossFadeAlpha(1f, 2f, false);
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene("gosokGigi");
            print("goblog");
        }
    }
}
