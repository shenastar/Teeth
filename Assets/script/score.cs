using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public Text papanScore;
    int finalscore = 0;

    private void Awake()
    {
        finalscore = PlayerPrefs.GetInt("scoreGigi");
    }
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        papanScore.text = "Score: " + finalscore;
    }
}
