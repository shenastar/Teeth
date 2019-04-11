using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teeth : MonoBehaviour {

    public Teeth nextTooth;

    public int calculus;

    public BrushMain mainBrush;

    void Start()
    {
        mainBrush = FindObjectOfType<BrushMain>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (Brushing.nextTooth == this && Brushing.Calculus > 0)
        {
            if (calculus > 0)
            {
                calculus--;
                Brushing.score+=10;
            }
            mainBrush.UpdateCal();
        }

        Brushing.curTooth = this;
        Brushing.nextTooth = nextTooth;
        /*
		print ("current tooth " + Brushing.curTooth.gameObject.name);
		print ("next tooth " + Brushing.nextTooth.gameObject.name);
		print ("current score " + Brushing.score);
		*/
    }
}
