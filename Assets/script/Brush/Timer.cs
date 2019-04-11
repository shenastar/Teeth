using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public int minutes;
    public int seconds;

    private float time;
    private float counter;

    public static bool start;

    // Use this for initialization
    void Awake()
    {
        time = (minutes * 60.0f) + seconds;
        counter = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            counter -= Time.deltaTime;

            start = counter <= 0 ? false : true;
        }

    }

    public float getTime
    {
        get
        {
            return time;
        }
    }
}
