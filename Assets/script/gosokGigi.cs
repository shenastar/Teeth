using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gosokGigi : MonoBehaviour {

	// Use this for initialization
    bool masukGosok = false;
    kid a = new kid();
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gogosokGigi();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("father"))
        {
            Debug.Log("kidfat");
            masukGosok = true;  
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        masukGosok = false;
    }
    void gogosokGigi()
    {
        if (masukGosok == true && PlayerPrefs.GetInt("validAnak") == 1)
        {
            Debug.Log(a.ajakAnak.ToString());
            Debug.Log("masuk");
            if (Input.GetKey(KeyCode.Space))
            {
                PlayerPrefs.SetInt("validAnak", 0);
                SceneManager.LoadScene("gosokGigi");
            }
        }
    }
}
