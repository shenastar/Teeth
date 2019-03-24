using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {

	public float speed;
	Rigidbody2D r;
	Vector3 target;
	private float startTime;
	private float journeyLength;
    private Animator anim;

    public static bool isMoving;

    public GameObject currentRoom, prevRoom;

	int orientation;

	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody2D> ();
		startTime = Time.time;
        target = transform.position;
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) ) {
            
			target = Camera.main.ScreenToWorldPoint (Input.mousePosition);			
			target.z = transform.position.z;
            target.y = transform.position.y;
		}
        
        journeyLength = Vector3.Distance(transform.position, target);
        float fracJourney = speed / journeyLength;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, target, fracJourney);
        transform.position = smoothedPosition;

        if (transform.position != target) {
            anim.SetBool("jalan", true);
            isMoving = true;
        }else
            anim.SetBool("jalan", false);
            isMoving = false;
    }
    


}
