using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Testami : MonoBehaviour {

	static Canvas _canvas;

	// Use this for initialization
	void Start () {
		_canvas = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	public static void SetActive(string name, bool b) {
		foreach (Transform child in _canvas.transform) {
			if (child.name == name) {
				child.gameObject.SetActive (b);
				return;
			}
		}
	}
		
}
