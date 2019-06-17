using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellowlight1 : MonoBehaviour {

    public Renderer rendG;
    public float timeleft = 13.0f;
    public int x = 0;

    // Use this for initialization
    void Start()
    {
        rendG = GetComponent<Renderer>();
        rendG.enabled = false;

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
                    rendG.enabled = true;
                    timeleft = 2.0f;
                    x = 1;
                    break;
                case 1:
                    rendG.enabled = false;
                    timeleft = 58.0f;
                    x = 0;
                    break;
                default:
                    print("Something is Wrong");
                    break;

            }
        }
    }
}
