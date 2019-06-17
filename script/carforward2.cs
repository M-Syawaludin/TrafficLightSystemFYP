using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carforward2 : MonoBehaviour
{

    public GameObject PSphere;
    public Renderer rend;
    public GameObject PSphereY;
    public Renderer rendY;
    public bool lampu = true;

    Vector3 Destination = new Vector3(-1.0f, 1.05f, 34.0f);
    bool isMoving = true;

    // Use this for initialization
    void Start()
    {
        PSphere = GameObject.Find("Red 2");
        rend = PSphere.GetComponent<Renderer>();
        PSphereY = GameObject.Find("Yellow 2");
        rendY = PSphereY.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        if (isMoving == true)
            transform.position = Vector3.MoveTowards(transform.position, Destination, 1f * Time.deltaTime * 2);
        if ((rend.isVisible == true || rendY.isVisible == true) && (transform.position.z < -4.0f && transform.position.z > -5.0f))
        {
            isMoving = false;
        }

        if (rend.isVisible == false)
        {
            isMoving = true;
        }



        //if (isMoving)
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * 2f);
        //}

        ////Debug.Log(transform.position.z);

        //if (rend.isVisible && transform.position == TrafficLight)
        //{
        //    // transform.Translate(Vector3.zero);
        //    isMoving = false;
        //}
        //else
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * 2f);
        //}
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FreeCar2(Clone)")
        {
            isMoving = false;
        }
    }
}
