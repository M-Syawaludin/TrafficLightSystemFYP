using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redlight1 : MonoBehaviour {
    public Renderer rendR;
    public float timeleft = 15.0f;
    public int x = 0;

    // Use this for initialization
    void Start()
    {
        rendR = GetComponent<Renderer>();
        rendR.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        timeleft = timeleft - Time.deltaTime;

        if (timeleft <= 0)
        {
            switch (x)
            {
                case 0:
                    rendR.enabled = true;
                    timeleft = 45.0f;
                    x = 1;
                    break;
                case 1:
                    rendR.enabled = false;
                    timeleft = 15.0f;
                    x = 0;
                    break;
                default:
                    print("Something is Wrong");
                    break;

            }
        }
    }
}
