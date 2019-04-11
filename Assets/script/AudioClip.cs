using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClip : MonoBehaviour {

    public AudioClip musicClip;
    public AudioSource musicSource;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        musicSource.Play();
	}
}
