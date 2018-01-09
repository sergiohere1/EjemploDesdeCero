﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAgain : MonoBehaviour {
    public float speed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
	}
}
