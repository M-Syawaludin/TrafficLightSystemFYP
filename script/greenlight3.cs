﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greenlight3 : MonoBehaviour {
    public Renderer rendG;
    public float timeleft = 30.0f;
    public int x = 1;

    // Use this for initialization
    void Start () {
        rendG = GetComponent<Renderer>();
        rendG.enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
        timeleft = timeleft - Time.deltaTime;

        if (timeleft <= 0)
        {
            switch (x)
            {
                case 0:
                    rendG.enabled = false;
                    timeleft = 47.0f;
                    x = 1;
                    break;
                case 1:
                    rendG.enabled = true;
                    timeleft = 13.0f;
                    x = 0;
                    break;
                default:
                    print("Something is Wrong");
                    break;
                
            }
        }
	}
}
