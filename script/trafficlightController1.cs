using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficlightController1  : MonoBehaviour {
    public Renderer rendG;
    public Renderer rendY;
    public Renderer rendR;

    public float timeleft = 15.0f;
    public bool StateR;
    public bool StateG;
    public bool StateY;

    public GameObject PSphereG;
    public GameObject PSphereR;
    public GameObject PSphereY;

    public GameObject Detector;


    // Use this for initialization
    void Start () {
        PSphereG = GameObject.Find("green 1");
        PSphereY = GameObject.Find("Yellow 1");
        PSphereR = GameObject.Find("Red 1");

        Detector = GameObject.Find("DetectionLine1");
        CarDetector TheDetector = Detector.GetComponent<CarDetector>();


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
        CarDetector TheDetector = Detector.GetComponent<CarDetector>();
        //Debug.Log(TheDetector.Detection);


        if (timeleft <= 15.0f)
        {
            rendG.enabled = true;
            rendR.enabled = false;
            StateG = true;
            StateY = false;
            StateR = false;

            
        }

        if (timeleft <= 2.0f)
        {
            rendG.enabled = false;
            rendY.enabled = true;
            StateG = false;
            StateY = true;
            StateR = false;
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



    }
}
