using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour {
    public GameObject followTarget;
    public Vector3 targerPos;
    public float moveSpeed;
    public Vector3 max, min;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        targerPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y+1, transform.position.z);
        if (targerPos.x < max.x && targerPos.x > min.x)
        {
            transform.position = Vector3.Lerp(transform.position, targerPos, moveSpeed * Time.deltaTime);
        }
    }
}
