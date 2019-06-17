using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHangeCamera : MonoBehaviour {
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public bool x;
    int counter = 0;
 

    // Use this for initialization
    void Start () {
        cam1 = GameObject.Find("Main Camera");
        cam2 = GameObject.Find("Conrner Camera");
        cam3 = GameObject.Find("FreeMoving Camera");
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    x = cam1.activeSelf;
        //    if (x == true)
        //    {
        //        cam1.SetActive(false);
        //        cam2.SetActive(true);
        //    }
        //    else
        //    {
        //        cam1.SetActive(true);
        //        cam2.SetActive(false);
        //    }
        //}

        //if (Input.GetKeyDown(KeyCode.N))
        //{
        //    if (counter < 3) counter++;
        //    else counter = 0;
        //}

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (counter < 3) counter++;
            else counter = 0;
        }

        if (counter == 0)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            Cursor.visible = true;
            Screen.lockCursor = false;
        }
        else if (counter == 1)
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            Cursor.visible = true;
            Screen.lockCursor = false;
        }
        else if (counter == 2)
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            Cursor.visible = false;
            Screen.lockCursor = true;
        }

        //if (Input.GetKeyDown(KeyCode.C))
        //{
        //    //x = cam1.activeSelf;
        //    if (x == true)
        //    {
        //        cam1.SetActive(false);
        //        cam3.SetActive(true);
        //        Cursor.visible = false;
        //        Screen.lockCursor = true;
        //    }
        //    else
        //    {
        //        cam1.SetActive(true);
        //        cam3.SetActive(false);
        //        Cursor.visible = true;
        //        Screen.lockCursor = false;
        //    }
        //}


    }
}
