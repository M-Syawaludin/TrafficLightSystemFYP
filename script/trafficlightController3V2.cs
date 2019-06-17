using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trafficlightController3V2 : MonoBehaviour {
    public Renderer rendG;
    public Renderer rendY;
    public Renderer rendR;

    //public float timeleft = 45.0f;

    public GameObject PSphereG;
    public GameObject PSphereR;
    public GameObject PSphereY;

    public GameObject Detector;

    // Use this for initialization
    void Start () {
        PSphereG = GameObject.Find("green 3");
        PSphereY = GameObject.Find("Yellow 3");
        PSphereR = GameObject.Find("Red 3");

        Detector = GameObject.Find("DetectionLine3");

        rendG = PSphereG.GetComponent<Renderer>();
        rendG.enabled = false;
        rendY = PSphereY.GetComponent<Renderer>();
        rendY.enabled = false;
        rendR = PSphereR.GetComponent<Renderer>();
        rendR.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        //timeleft = timeleft - Time.deltaTime;
        CarDetector TheDetector = Detector.GetComponent<CarDetector>();

        //if (timeleft <= 15.0f)
        //{
        //    rendG.enabled = true;
        //    rendR.enabled = false;
        //}

        //if (timeleft <= 2.0f)
        //{
        //    rendG.enabled = false;
        //    rendY.enabled = true;
        //}

        //if (timeleft <= 0.0f)
        //{
        //    rendY.enabled = false;
        //    rendR.enabled = true;
        //    timeleft = 60.0f;

        //}



    }
}
