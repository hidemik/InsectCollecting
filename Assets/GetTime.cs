using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTime : MonoBehaviour {

	private GameObject TimeText;

	// Use this for initialization
	void Start () {
		this.TimeText = GameObject.Find ("TimeText");
	}
	
	// Update is called once per frame
	void Update () {
		string time = DateTime.Now.ToString("hh:mm");
		TimeText.GetComponent<Text> ().text = time;
	}
}
