using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameMaster : MonoBehaviour {

    // Use this for initialization
    public Camera cameraMain;
    public Camera camera2;
    public GameObject karakter;
    public GameObject gameGigi;
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ChangeCamera(cameraMain, camera2);
            karakter.GetComponent<move>().enabled = false;
            gameGigi.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            ChangeCamera(camera2, cameraMain);
            karakter.GetComponent<move>().enabled = true;
            gameGigi.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            karakter.GetComponent<move>().enabled = false;
        }
    }

    public void ChangeCamera(Camera oldCamera, Camera newCamera)
    {
        oldCamera.enabled = false;
        newCamera.enabled = true;
    }

}
