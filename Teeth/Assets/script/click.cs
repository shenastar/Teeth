using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour {
    public GameObject objects;
    public GameObject pos;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            objects.SetActive(true);
            transform.parent.gameObject.SetActive(false);
        }
    }
}
