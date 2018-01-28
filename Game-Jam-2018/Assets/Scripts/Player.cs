﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Health hp;
    public bool isAttacking;
    public Image HpBar;

	// Use this for initialization
	void Start () {
        hp = GetComponent<Health>();
        hp.value = 50f;
        hp.max = 50f;
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void UpdateHealthBar() {
        HpBar.fillAmount = hp.value / hp.max;
    }
    public void OnHit(GameObject source, float dmg) {
        hp.value -= dmg;
        UpdateHealthBar();
    }


    /*
     TO DO:
        Encase HP with a setter/getter
     */
}
