using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manual : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick(){
		GetComponent<AudioSource> ().Play ();
		Testami.SetActive ("Bun", true);
	}
}
