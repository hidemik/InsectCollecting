using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsController : MonoBehaviour {

	private float time = 0;
	private float span = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.time += Time.deltaTime;
		if (this.time > this.span) {
			Destroy (gameObject);
		}
	}
}
