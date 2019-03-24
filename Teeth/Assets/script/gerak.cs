using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerak : MonoBehaviour {

    int carSpeed = 5;
    Rigidbody2D r;
	// Use this for initialization
	void Start () {
        r = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //Vector2 pos = Vector2.MoveTowards(transform.position, target.transform.position, carSpeed * Time.deltaTime);
        // r adalah rigid body, lihat di bagian deklarasi variable dan method start untuk inisialisasinya
        

        Vector3 targetv3 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = Vector2.MoveTowards(transform.position, new Vector2(targetv3.x, targetv3.y), carSpeed * Time.deltaTime);
        // r adalah rigid body, lihat di bagian deklarasi variable dan method start untuk inisialisasinya
        r.MovePosition(pos);
    }
}
