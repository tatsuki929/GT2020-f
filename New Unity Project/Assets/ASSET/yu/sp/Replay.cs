﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ReplayGame()
    {
        // PlayerGoal.goalp = false;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
