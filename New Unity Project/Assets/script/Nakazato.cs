﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nakazato : MonoBehaviour {


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Stone")
        {
            if (Input.GetKey(KeyCode.D)
              ||Input.GetButtonDown("DS4_Triangle"))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
