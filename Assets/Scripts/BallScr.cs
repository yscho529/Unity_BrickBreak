﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScr : MonoBehaviour {

    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -60);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
