using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carforward4 : MonoBehaviour {

    public GameObject PSphere;
    public Renderer rend;
    public GameObject PSphereY;
    public Renderer rendY;
    //public bool lampu=true;

    Vector3 Destination = new Vector3(1.0f, 1.05f, -34.0f);
    bool isMoving = true;

    // Use this for initialization
    void Start()
    {
        PSphere = GameObject.Find("Red 4");
        rend = PSphere.GetComponent<Renderer>();
        PSphereY = GameObject.Find("Yellow 4");
        rendY = PSphereY.GetComponent<Renderer>(); 
    }

    // Update is called once per frame
    void Update () {

        if (isMoving == true)
            transform.position = Vector3.MoveTowards(transform.position, Destination, 1f * Time.deltaTime * 2);
        if ((rend.isVisible == true || rendY.isVisible == true) && (transform.position.z < 5.0f && transform.position.z > 4.0f))
        {
            isMoving = false;
        }

        if (rend.isVisible == false)
        {
            isMoving = true;
        }


        //transform.Translate(Vector3.forward * Time.deltaTime*2);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FreeCar4(Clone)")
        {
            isMoving = false;
        }
    }
}
