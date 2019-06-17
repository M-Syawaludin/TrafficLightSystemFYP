using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarForwardFast : MonoBehaviour {
    public GameObject PSphere;
    public Renderer rend;
    public GameObject PSphereY;
    public Renderer rendY;
    public GameObject cube;
    public Rigidbody rb;
    public GameObject Car;
    public Collision carr;
    float xpos;

    Vector3 Destination = new Vector3(34.0f, 1.05f, 1.0f);
    bool isMoving = true;
    // Use this for initialization
    void Start () {
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
		
	}
    private void FixedUpdate()
    {
        if (isMoving == true)
            //transform.position = Vector3.MoveTowards(transform.position, Destination, 1f * Time.deltaTime * 2);
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime * 4);

        if ((rend.isVisible == true || rendY.isVisible == true) && (transform.position.x < -4.0f && transform.position.x > -5.0f))
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
        if (collision.gameObject.name == "FreeCarFast(Clone)")
        {
            isMoving = false;
        }
    }
}
