﻿using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
