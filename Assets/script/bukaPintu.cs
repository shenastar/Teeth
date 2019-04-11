using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bukaPintu : MonoBehaviour {
    public GameObject pintuTutup, pintuBuka;
    bool status = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        openDoor();
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("father"))
        {
            status = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        status = false;
        pintuTutup.SetActive(true);
        pintuBuka.SetActive(false);
    }
    void openDoor()
    {
        if (status == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                pintuTutup.SetActive(false);
                pintuBuka.SetActive(true);
            }
            else
            {
                
            }
        }
    }
}
