using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

	private AsyncOperation async;
	public GameObject LoadingUi;
	public Slider Slider;

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			LoadNextScene ();
			GetComponent<AudioSource> ().Play ();
		}
	}

	public void LoadNextScene() {
		LoadingUi.SetActive(true);
		StartCoroutine(LoadScene());
	}

	IEnumerator LoadScene() {
		async = SceneManager.LoadSceneAsync("GameScene");

		while (!async.isDone) {
			Slider.value = async.progress;
			yield return null;
		}
	}
}