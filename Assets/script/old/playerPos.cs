using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPos : MonoBehaviour {
    public GameObject player;
    Vector3 tempPos;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        tempPos = transform.position;
        player.transform.position = tempPos;
    }
    
}
