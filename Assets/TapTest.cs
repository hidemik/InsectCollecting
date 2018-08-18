using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapTest : MonoBehaviour {

	public GameObject MoveTarget;
	float fowardForce = 5.0f;

	float RequiredTime = 0.0f;
	float CountTime = 1.0f;

	int Score = 0;
	private GameObject ScoreText;
	private GameObject GetName;

	public AudioClip kira;
	public AudioClip piron;
	public AudioClip pochi;
	private AudioSource audioSource;

	void Start(){
		this.ScoreText = GameObject.Find ("ScoreText");
		this.GetName = GameObject.Find ("GetName");
		this.audioSource = gameObject.GetComponent<AudioSource> ();
	}

	void Update(){
		//画面長押しと離したときの判定
		foreach (Touch touch in Input.touches) {
			if (Input.GetMouseButtonDown (0)) {
				RequiredTime = Time.time + CountTime;
			}
			if (Input.GetMouseButton (0) && RequiredTime < Time.time) {
					Move ();
			} else if (Input.GetMouseButtonUp(0)) {
					Stop ();
			}
		}
	}
	//長押しカメラ前方向に進む
	public void Move(){
		MoveTarget.GetComponent<Rigidbody> ().velocity = MoveTarget.transform.forward * this.fowardForce;
	}
	//離すとカメラ止まる
	public void Stop(){
		MoveTarget.GetComponent<Rigidbody> ().velocity = Vector3.zero;
	}
	//カゴに捕獲数表示
	public void GetScore(){
		this.Score += 1;
		this.ScoreText.GetComponent<Text> ().text = this.Score.ToString();
		audioSource.clip = this.piron;
		audioSource.Play ();
	}

	public void Getkira(){
		audioSource.clip = this.kira;
		audioSource.Play ();
	}

	public void OnClickb(){
		Testami.SetActive ("Bun", false);
		audioSource.clip = this.pochi;
		audioSource.Play ();
	}

	public void OnClickl(){
		this.GetName.transform.position = new Vector3 (257, -326, 0);
		audioSource.clip = this.pochi;
		audioSource.Play ();
	}
}