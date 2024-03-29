﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hexagon : MonoBehaviour {

	public Rigidbody2D rb;
	public Transform trans;

	public float shrinkSpeed = 3f;
	// Use this for initialization
	void Start () {
		//rb.rotation = Random.Range(0f, 360f);
		transform.Rotate(0f, 0f, Random.Range(0f, 360f));
		transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

		if(transform.localScale.x <= 0.05f){
			Destroy(gameObject); 
		}
	}
}
