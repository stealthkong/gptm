﻿using UnityEngine;
using System.Collections;

public class openCutScript2 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	public GameObject text4;
	public GameObject text5;
	public int x;
	
	// Use this for initialization
	void Start () {
		
		text1.SetActive(false);
		text2.SetActive(false);
		text3.SetActive(false);
		text4.SetActive(false);
		text5.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.anyKey){
			text1.SetActive(true);
			text2.SetActive(true);
			text3.SetActive(true);
			text4.SetActive(true);
			text5.SetActive(true);
		}
		if (Input.GetKey(KeyCode.Space)) {
			Application.LoadLevel(3);
		}
		
		
	}
}