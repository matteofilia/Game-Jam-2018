﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public Health hp;
	// Use this for initialization
	void Start () {
        hp = GetComponent<Health>();
        hp.value = 25f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnHit(GameObject p) {

    }
}