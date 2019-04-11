using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tanggga : MonoBehaviour {
    public GameObject player,player2;
    public GameObject posAwal;
    public GameObject posAkir;
    private Vector3 position;
    bool statusF = false, statusK = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        naikTurun();
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("father"))
        {
            statusF = true;
        }
        if (collision.gameObject.CompareTag("kid"))
        {
            statusK = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        statusF = false;
        statusK = false;
    }
    void naikTurun()
    {
        if(statusF == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.transform.position = posAkir.transform.position;
                statusF = false;
            }
        }
        if (statusK == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player2.transform.position = posAkir.transform.position;
                statusK = false;
            }
        }
    }
}
