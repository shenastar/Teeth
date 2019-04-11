using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehaviour {

    public float speed;
    Rigidbody2D r;
    Vector3 target;
    private float startTime;
    private float journeyLength;
    int orientation;

    // Use this for initialization
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }

        journeyLength = Vector3.Distance(transform.position, target);
        float fracJourney = speed / journeyLength;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, target, fracJourney);
        transform.position = smoothedPosition;
    }
}
