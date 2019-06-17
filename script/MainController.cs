using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    //Traffic Light 1
    public float timeleft;

    public Renderer rendG;
    public Renderer rendY;
    public Renderer rendR;

    public bool StateR;
    public bool StateG;
    public bool StateY;

    public GameObject PSphereG;
    public GameObject PSphereR;
    public GameObject PSphereY;

    public GameObject Detector;

    //Traffic Light 2
    public float timeleft2;

    public Renderer rendG2;
    public Renderer rendY2;
    public Renderer rendR2;

    public bool StateR2;
    public bool StateG2;
    public bool StateY2;

    public GameObject PSphereG2;
    public GameObject PSphereR2;
    public GameObject PSphereY2;

    public GameObject Detector2;

    //traffic Light 3
    public float timeleft3;

    public Renderer rendG3;
    public Renderer rendY3;
    public Renderer rendR3;

    public bool StateR3;
    public bool StateG3;
    public bool StateY3;

    public GameObject PSphereG3;
    public GameObject PSphereR3;
    public GameObject PSphereY3;

    public GameObject Detector3;

    //Traffic Light 4
    public float timeleft4;

    public Renderer rendG4;
    public Renderer rendY4;
    public Renderer rendR4;

    public bool StateR4;
    public bool StateG4;
    public bool StateY4;

    public GameObject PSphereG4;
    public GameObject PSphereR4;
    public GameObject PSphereY4;

    public GameObject Detector4;

   
    public int turn = 1;
    public int Detected = 0;
    public bool Exceeded=false;
    public float timer2 = 30;

    // Use this for initialization
    void Start () {
        timeleft = 3.0f;
        timer2 = 30;

        PSphereG = GameObject.Find("green 1");
        PSphereY = GameObject.Find("Yellow 1");
        PSphereR = GameObject.Find("Red 1");

        Detector = GameObject.Find("DetectionLine1");
        CarDetector DetectionL1 = Detector.GetComponent<CarDetector>();


        rendG = PSphereG.GetComponent<Renderer>();
        rendG.enabled = true;
        rendY = PSphereY.GetComponent<Renderer>();
        rendY.enabled = false;
        rendR = PSphereR.GetComponent<Renderer>();
        rendR.enabled = false;

        PSphereG2 = GameObject.Find("green 2");
        PSphereY2 = GameObject.Find("Yellow 2");
        PSphereR2 = GameObject.Find("Red 2");

        Detector2 = GameObject.Find("DetectionLine2");
        CarDetector DetectionL2 = Detector2.GetComponent<CarDetector>();

        rendG2 = PSphereG2.GetComponent<Renderer>();
        rendG2.enabled = false;
        rendY2 = PSphereY2.GetComponent<Renderer>();
        rendY2.enabled = false;
        rendR2 = PSphereR2.GetComponent<Renderer>();
        rendR2.enabled = true;

        PSphereG3 = GameObject.Find("green 3");
        PSphereY3 = GameObject.Find("Yellow 3");
        PSphereR3 = GameObject.Find("Red 3");

        Detector3 = GameObject.Find("DetectionLine3");
        CarDetector DetectionL3 = Detector3.GetComponent<CarDetector>();

        rendG3 = PSphereG3.GetComponent<Renderer>();
        rendG3.enabled = false;
        rendY3 = PSphereY3.GetComponent<Renderer>();
        rendY3.enabled = false;
        rendR3 = PSphereR3.GetComponent<Renderer>();
        rendR3.enabled = true;

        PSphereG4 = GameObject.Find("green 4");
        PSphereY4 = GameObject.Find("Yellow 4");
        PSphereR4 = GameObject.Find("Red 4");

        Detector4 = GameObject.Find("DetectionLine4");
        CarDetector DetectionL4 = Detector4.GetComponent<CarDetector>();

        rendG4 = PSphereG4.GetComponent<Renderer>();
        rendG4.enabled = false;
        rendY4 = PSphereY4.GetComponent<Renderer>();
        rendY4.enabled = false;
        rendR4 = PSphereR4.GetComponent<Renderer>();
        rendR4.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        CarDetector DetectionL1 = Detector.GetComponent<CarDetector>();
        CarDetector DetectionL2 = Detector2.GetComponent<CarDetector>();
        CarDetector DetectionL3 = Detector3.GetComponent<CarDetector>();
        CarDetector DetectionL4 = Detector4.GetComponent<CarDetector>();
        //timer2=timer2 + Time.deltaTime;
        if (DetectionL1.Detection > 0 || DetectionL2.Detection > 0 || DetectionL3.Detection > 0 || DetectionL4.Detection > 0)
        {

            timer2 = timer2 - Time.deltaTime;
        }

        //Green light
        if (turn == 1)
        {
            if(DetectionL1.Detection > Detected)
            {
                //if (rendY.enabled != true && Exceeded == false && Detected<DetectionL1.Detection)
                //{
                //    timeleft = timeleft + 2;
                //    Detected++;
                //}

                //if (timeleft > 13.0f)
                //{
                //    Exceeded = true;
                //    timeleft = 2.0f;
                //    //rendG.enabled = false;
                //    //rendY.enabled = true;

                //}

                if (rendY.enabled != true && Exceeded == false && Detected < DetectionL1.Detection)
                {
                    //timer2=timer2 - 1;
                    timeleft = timeleft + 2;
                    Detected++;
                }
                if (timer2 <=0 && Exceeded == false)
                {
                    Exceeded = true;
                    timeleft = 2.0f;
                    //rendG.enabled = false;
                    //rendY.enabled = true;

                }


            }
            else
            {
                if (rendY.enabled != true && (DetectionL2.Detection > 0 || DetectionL3.Detection > 0 || DetectionL4.Detection > 0))
                {
                    timeleft = timeleft - Time.deltaTime;
                }
                else if (rendY.enabled != true)
                {
                  //  Debug.Log("no car on other lane");
                }
            }
        }
        if (turn == 2)
        {
            if (DetectionL2.Detection > Detected)
            {
                //if (rendY2.enabled != true && Exceeded == false && Detected < DetectionL2.Detection)
                //{
                //    timeleft2 = timeleft2 + 2;
                //    Detected++;
                //}

                //if (timeleft2 >= 13.0f)
                //{
                //    Exceeded = true;
                //    timeleft2 = 2.0f;

                //}
                if (rendY2.enabled != true && Exceeded == false && Detected < DetectionL2.Detection)
                {
                    //timer2 = timer2 - 1;
                    timeleft2 = timeleft2 + 2;
                    Detected++;
                }

                if (timer2 <= 0 && Exceeded == false)
                {
                    Exceeded = true;
                    timeleft2 = 2.0f;
                    //rendG.enabled = false;
                    //rendY.enabled = true;

                }

 
            }
            else
            {
                if (rendY2.enabled != true && (DetectionL1.Detection > 0 || DetectionL3.Detection > 0 || DetectionL4.Detection > 0))
                {
                    timeleft2 = timeleft2 - Time.deltaTime;
                }
                else if (rendY2.enabled != true) { }
            }
        }
        if (turn == 3)
        {
            if (DetectionL3.Detection > Detected)
            {
                //if (rendY3.enabled != true && Exceeded == false && Detected < DetectionL3.Detection)
                //{
                //    timeleft3 = timeleft3 + 2;
                //    Detected++;
                //}

                //if (timeleft3 >= 13.0f)
                //{
                //    Exceeded = true;
                //    timeleft3 = 2.0f;

                //}
                if (rendY3.enabled != true && Exceeded == false && Detected < DetectionL3.Detection)
                {
                    //timer2 = timer2 - 1;
                    timeleft3 = timeleft3 + 2;
                    Detected++;
                }

                if (timer2 <= 0 && Exceeded == false)
                {
                    Exceeded = true;
                    timeleft3 = 2.0f;
                    //rendG.enabled = false;
                    //rendY.enabled = true;

                }


            }
            else
            {
                if (rendY3.enabled != true && (DetectionL2.Detection > 0 || DetectionL1.Detection > 0 || DetectionL4.Detection > 0))
                {
                    timeleft3 = timeleft3 - Time.deltaTime;
                }
                else if (rendY3.enabled != true) { }
            }
        }
        if (turn == 4)
        {
            if (DetectionL4.Detection > Detected)
            {
                //if (rendY4.enabled != true && Exceeded == false && Detected < DetectionL4.Detection)
                //{
                //    timeleft4 = timeleft4 + 2;
                //    Detected++;
                //}

                //if (timeleft4 >= 13.0f)
                //{
                //    Exceeded = true;
                //    timeleft4 = 2.0f;

                //}
                if (rendY4.enabled != true && Exceeded == false && Detected < DetectionL4.Detection)
                {
                    //timer2 = timer2 - 1;
                    timeleft4 = timeleft4 + 2;
                    Detected++;
                }

                if (timer2 <= 0 && Exceeded == false)
                {
                    Exceeded = true;
                    timeleft4 = 2.0f;
                    //rendG.enabled = false;
                    //rendY.enabled = true;

                }

  
            }
            else
            {
                if (rendY4.enabled != true && (DetectionL2.Detection > 0 || DetectionL3.Detection > 0 || DetectionL1.Detection > 0))
                {
                    timeleft4 = timeleft4 - Time.deltaTime;
                }
                else if (rendY4.enabled != true)
                {

                }
            }
        }

        //Yellow light
        if (turn == 1)
        {
            if (timeleft>0 && timeleft <= 2)
            {
                timeleft = timeleft - Time.deltaTime;
                rendG.enabled = false;
                rendY.enabled = true;
            }
            //RedLight1
            else if (timeleft <= 0.0f)
            {
                timeleft = 3.0f;
                Exceeded = false;
                timer2 = 30;
                rendY.enabled = false;
                rendR.enabled = true;
                DetectionL1.Detection = 0;
                Detected = 0;   

                if (Detected == DetectionL2.Detection)
                {
                    turn = 3;
                    timeleft3 = 3.0f;
                    rendR3.enabled = false;
                    rendG3.enabled = true;
                    if (Detected == DetectionL3.Detection)
                    {
                        turn = 4;
                        timeleft3 = 0.0f;
                        timeleft4 = 3.0f;
                        rendR3.enabled = true;
                        rendG3.enabled = false;
                        rendR4.enabled = false;
                        rendG4.enabled = true;
                        if (Detected == DetectionL4.Detection)
                        {
                            //turn = 2;
                            //timeleft4 = 0.0f;
                            //timeleft2 = 6.0f;
                            //rendR4.enabled = true;
                            //rendG4.enabled = false;
                            //rendR2.enabled = false;
                            //rendG2.enabled = true;
                            turn = 1;
                            timeleft4 = 0.0f;
                            timeleft = 3.0f;
                            rendR4.enabled = true;
                            rendG4.enabled = false;
                            rendR.enabled = false;
                            rendG.enabled = true;
                        }
                    }
                }
                else
                {
                    turn = 2;
                    timeleft2 = 6.0f;
                    rendR2.enabled = false;
                    rendG2.enabled = true;
                }

            }
        }
        if (turn == 2)
        {
            if (timeleft2 > 0 && timeleft2 <= 2)
            {
                timeleft2 = timeleft2 - Time.deltaTime;
                rendG2.enabled = false;
                rendY2.enabled = true;
            }
            //RedLight2
            else if (timeleft2 <= 0.0f)
            {
                timeleft2 = 6.0f;
                Exceeded = false;
                timer2 = 30;
                rendY2.enabled = false;
                rendR2.enabled = true;
                DetectionL2.Detection = 0;
                Detected = 0;

                if (Detected == DetectionL3.Detection)
                {
                    turn = 4;
                    timeleft4 = 6.0f;
                    rendR4.enabled = false;
                    rendG4.enabled = true;
                    if (Detected == DetectionL4.Detection)
                    {
                        turn = 1;
                        timeleft4 = 0.0f;
                        timeleft = 6.0f;
                        rendR4.enabled = true;
                        rendG4.enabled = false;
                        rendR.enabled = false;
                        rendG.enabled = true;
                        if (Detected == DetectionL1.Detection)
                        {
                            turn = 2;
                            timeleft = 0.0f;
                            timeleft2 = 6.0f;
                            rendR.enabled = true;
                            rendG.enabled = false;
                            rendR2.enabled = false;
                            rendG2.enabled = true;
                            //turn = 3;
                            //timeleft = 0.0f;
                            //timeleft3 = 6.0f;
                            //rendR.enabled = true;
                            //rendG.enabled = false;
                            //rendR3.enabled = false;
                            //rendG3.enabled = true;
                        }
                    }
                }
                else
                {
                    turn = 3;
                    timeleft3 = 6.0f;
                    rendR3.enabled = false;
                    rendG3.enabled = true;
                }

            }
        }
        if (turn == 3)
        {
            if (timeleft3 > 0 && timeleft3 <= 2)
            {
                timeleft3 = timeleft3 - Time.deltaTime;
                rendG3.enabled = false;
                rendY3.enabled = true;
            }
            //RedLight3
            else if (timeleft3 <= 0.0f)
            {
                timeleft = 6.0f;
                Exceeded = false;
                timer2 = 30;
                rendY3.enabled = false;
                rendR3.enabled = true;
                DetectionL3.Detection = 0;
                Detected = 0;

                if (Detected == DetectionL4.Detection)
                {
                    turn = 1;
                    timeleft = 6.0f;
                    rendR.enabled = false;
                    rendG.enabled = true;
                    if (Detected == DetectionL1.Detection)
                    {
                        turn = 2;
                        timeleft = 0.0f;
                        timeleft2 = 6.0f;
                        rendR.enabled = true;
                        rendG.enabled = false;
                        rendR2.enabled = false;
                        rendG2.enabled = true;
                        if (Detected == DetectionL2.Detection)
                        {
                            //turn = 4;
                            //timeleft2 = 0.0f;
                            //timeleft4 = 6.0f;
                            //rendR2.enabled = true;
                            //rendG2.enabled = false;
                            //rendR4.enabled = false;
                            //rendG4.enabled = true;
                            turn = 3;
                            timeleft2 = 0.0f;
                            timeleft3 = 6.0f;
                            rendR2.enabled = true;
                            rendG2.enabled = false;
                            rendR3.enabled = false;
                            rendG3.enabled = true;
                        }
                    }
                }
                else
                {
                    turn = 4;
                    timeleft4 = 6.0f;
                    rendR4.enabled = false;
                    rendG4.enabled = true;
                }

            }
        }
        if (turn == 4)
        {
            if (timeleft4 > 0 && timeleft4 <= 2)
            {
                timeleft4 = timeleft4 - Time.deltaTime;
                rendG4.enabled = false;
                rendY4.enabled = true;
            }
            //RedLight4
            else if (timeleft4 <= 0.0f)
            {
                timeleft4 = 6.0f;
                Exceeded = false;
                timer2 = 30;
                rendY4.enabled = false;
                rendR4.enabled = true;
                DetectionL4.Detection = 0;
                Detected = 0;

                if (Detected == DetectionL1.Detection)
                {
                    turn = 2;
                    timeleft2 = 6.0f;
                    rendR2.enabled = false;
                    rendG2.enabled = true;
                    if (Detected == DetectionL2.Detection)
                    {
                        turn = 3;
                        timeleft2 = 0.0f;
                        timeleft3 = 6.0f;
                        rendR2.enabled = true;
                        rendG2.enabled = false;
                        rendR3.enabled = false;
                        rendG3.enabled = true;
                        if (Detected == DetectionL3.Detection)
                        {
                            //turn = 1;
                            //timeleft3 = 0.0f;
                            //timeleft = 6.0f;
                            //rendR3.enabled = true;
                            //rendG3.enabled = false;
                            //rendR.enabled = false;
                            //rendG.enabled = true;
                            turn = 4;
                            timeleft3 = 0.0f;
                            timeleft4 = 6.0f;
                            rendR3.enabled = true;
                            rendG3.enabled = false;
                            rendR4.enabled = false;
                            rendG4.enabled = true;
                        }
                    }
                }
                else
                {
                    turn = 1;
                    timeleft = 6.0f;
                    rendR.enabled = false;
                    rendG.enabled = true;
                }

            }
        }


    }
}
