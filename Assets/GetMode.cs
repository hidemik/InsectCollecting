using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMode : MonoBehaviour {

	public GameObject Name;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnClick(){
		GetComponent<AudioSource> ().Play ();
		this.Name.transform.position = new Vector3 (160, 240, 0);
	}
}
