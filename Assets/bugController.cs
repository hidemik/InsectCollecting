using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bugController : MonoBehaviour {

	public GameObject Stars;
	private GameObject GetText;
	private bool isGet = false;
	private float delta = 0;
	private float span = 3.0f;

	// Use this for initialization
	void Start () {
		this.GetText = GameObject.Find ("GetText");
	}
	
	// Update is called once per frame
	void Update () {
		//Ｇｅｔ再度タッチで2秒後にスコアに加算昆虫削除
		if (this.isGet == true) {
			this.delta += Time.deltaTime;
			if (Input.GetMouseButtonDown (0) && this.delta > this.span) {
				this.delta = 0;
				GameObject.Find ("Canvas").GetComponent<TapTest> ().GetScore ();
				Name ();
				this.GetText.GetComponent<Text> ().text = "";
				GameObject.Find ("BugGenerator").GetComponent<bugGenerator> ().Generate ();
				Destroy (gameObject);
			}
		}
	}

	//昆虫がタッチされたら正面向いてキラキラする
	public void GetMode(){
		//見直し
		Vector3 p = Camera.main.transform.position;
		transform.LookAt (p);
		if (this.gameObject.tag == "ladybugTag") {
			Look ();
		}
		Star ();
		GetComponent<ParticleSystem> ().Stop ();
		this.GetText.GetComponent<Text> ().text = "G E T !!";
		GameObject.Find ("Canvas").GetComponent<TapTest> ().Getkira ();
		this.isGet = true;
	}

	void Star(){
		GameObject stars = Instantiate (Stars) as GameObject;
		stars.transform.position = this.transform.position;
	}

	public void Name(){
		if (this.gameObject.tag == "beetleTag") {
			GameObject.Find ("BugGenerator").GetComponent<bugViewer> ().BeName ();
		} else if (this.gameObject.tag == "ladybugTag") {
			GameObject.Find ("BugGenerator").GetComponent<bugViewer> ().LaName ();
		} else if (this.gameObject.tag == "acicadaTag") {
			GameObject.Find ("BugGenerator").GetComponent<bugViewer> ().AcName ();
		} else if (this.gameObject.tag == "mcicadaTag") {
			GameObject.Find ("BugGenerator").GetComponent<bugViewer> ().McName ();
		} else if (this.gameObject.tag == "butterflyTag") {
			GameObject.Find ("BugGenerator").GetComponent<bugViewer> ().BuName ();
		}
	}

	public void Look(){
		this.transform.Rotate (10, 180, 180);
	}
}