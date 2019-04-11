using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kid : MonoBehaviour {
    public Component allkid;
    public bool ajakAnak = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        jalanAnak();
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("father"))
        {
            ajakAnak = true;
            PlayerPrefs.SetInt("validAnak",1);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ajakAnak = false;
    }
    private void jalanAnak()
    {
        if (ajakAnak == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                allkid.GetComponent<BoxCollider2D>().isTrigger = false;
                allkid.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                allkid.GetComponent<move>().enabled = true;
            }
        }
    }
}
