﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBr : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Yougan")
        {
            Destroy(other.gameObject);
        }
    }
}
