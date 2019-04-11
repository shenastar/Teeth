using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wife : MonoBehaviour
{
    public Component aa;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            aa.GetComponent<move>().enabled = false;
            aa.GetComponent<BoxCollider2D>().isTrigger = true;
            aa.GetComponent<Rigidbody2D>().simulated = false;
        }
        if (Input.GetKey(KeyCode.G))
        {
            aa.GetComponent<move>().enabled = true;
            aa.GetComponent<BoxCollider2D>().isTrigger = false;
            aa.GetComponent<Rigidbody2D>().simulated = true;
        }
    }
}