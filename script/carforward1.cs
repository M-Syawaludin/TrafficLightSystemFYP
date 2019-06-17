using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carforward1 : MonoBehaviour {
    //public float minx = -4;
    //public float maxx = -5;
    public GameObject PSphere;
    public Renderer rend;
    public GameObject PSphereY;
    public Renderer rendY;
    public GameObject cube;
    public Rigidbody rb;
    public GameObject Car;
    public Collision carr;
    float xpos;
    //public bool lampu=true;

    //Vector3 TrafficLight = new Vector3(-4.0f, 1.05f, 1.0f);
    Vector3 Destination = new Vector3(34.0f, 1.05f, 1.0f);
    bool isMoving = true;

    //void OnTriggerEnter(Collider col)
    //{
    //    //Destroy(col.gameObject);
    //    Debug.Log("Collided");
    //}

    // Use this for initialization
    void Start () {
       // Car = GameObject.Find("FreeCar");
        //carr = Collision.Equals
        PSphere = GameObject.Find("Red 1");
        cube = GameObject.Find("cube");
        rend = PSphere.GetComponent<Renderer>();
        PSphereY = GameObject.Find("Yellow 1");
        rendY = PSphereY.GetComponent<Renderer>();
    Collider cubecol = PSphere.GetComponent<Collider>();

        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
        //if (isMoving)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, TrafficLight, 1f * Time.deltaTime * 2);
        //}
/*
        if (isMoving==true )
            transform.position = Vector3.MoveTowards(transform.position, Destination, 1f * Time.deltaTime * 2);

        if (rend.isVisible == true && (transform.position.x < -4.0f && transform.position.x > -5.0f))
        {
            isMoving = false;
        }

        if (rend.isVisible == false)
        {
            isMoving = true;
        }
*/
        //////Debug.Log(transform.position.z);
        /*
        if (rend.isVisible == true && transform.position == TrafficLight)
        {
            // transform.Translate(Vector3.zero);
            isMoving = false;
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 2f);
        }
        */
        //transform.Translate(Vector3.forward * Time.deltaTime * 2);
        //while (transform.position.x > minx && transform.position.x < maxx)
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * 0);
        //}

    }

    private void FixedUpdate()
    {
        if (isMoving == true)
            //transform.position = Vector3.MoveTowards(transform.position, Destination, 1f * Time.deltaTime * 2);
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * 2);

        if ((rend.isVisible == true || rendY.isVisible == true)  && (transform.position.x < -4.0f && transform.position.x > -5.0f))
        {
            isMoving = false;
        }        

        if (rend.isVisible == false)
        {
            isMoving = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FreeCar(Clone)")
        {
            isMoving = false;
        }
    }
}
