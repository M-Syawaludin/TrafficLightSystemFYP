using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficlightController1V2  : MonoBehaviour {
    public Renderer rendG;
    public Renderer rendY;
    public Renderer rendR;

    public float timeleft = 5.0f;
    public bool StateR;
    public bool StateG;
    public bool StateY;

    public GameObject PSphereG;
    public GameObject PSphereR;
    public GameObject PSphereY;

    public GameObject Detector1;
    public int Detected=0;


    // Use this for initialization
    void Start () {
        PSphereG = GameObject.Find("green 1");
        PSphereY = GameObject.Find("Yellow 1");
        PSphereR = GameObject.Find("Red 1");

        Detector1 = GameObject.Find("DetectionLine1");
        //  CarDetector TheDetector = Detector.GetComponent<CarDetector>();
         

        rendG = PSphereG.GetComponent<Renderer>();
        rendG.enabled = true;
        rendY = PSphereY.GetComponent<Renderer>();
        rendY.enabled = false;
        rendR = PSphereR.GetComponent<Renderer>();
        rendR.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        timeleft = timeleft - Time.deltaTime;
        CarDetector TheDetector = Detector1.GetComponent<CarDetector>();
        //Debug.Log(TheDetector.Detection);
        if (Detected < TheDetector.Detection)
        {
            if (StateG == true)
            {
                timeleft=timeleft+1;

                if (timeleft > 11)
                {
                    StateG = false;
                    StateY = true;
                }
            }
           // Detected = TheDetector.Detection;
        }

        if (StateY == true)
        {
            rendG.enabled = false;
            rendY.enabled = true; 
        }

        if (timeleft <= 0.0f)
        {
            rendY.enabled = false;
            rendR.enabled = true;
            StateG = false;
            StateY = false;
            StateR = true;
            timeleft = 60.0f;

        }


        //if (timeleft <= 15.0f)
        //{
        //    rendG.enabled = true;
        //    rendR.enabled = false;
        //    StateG = true;
        //    StateY = false;
        //    StateR = false;


        //}

        //if (timeleft <= 2.0f)
        //{
        //    rendG.enabled = false;
        //    rendY.enabled = true;
        //    StateG = false;
        //    StateY = true;
        //    StateR = false;
        //}

        //if (timeleft <= 0.0f)
        //{
        //    rendY.enabled = false;
        //    rendR.enabled = true;
        //    StateG = false;
        //    StateY = false;
        //    StateR = true;
        //    timeleft = 60.0f;

        //}



    }
}
