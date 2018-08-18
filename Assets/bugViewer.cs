using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bugViewer : MonoBehaviour {
	
	public GameObject BeetleName;
	public GameObject LadybugName;
	public GameObject AcicadaName;
	public GameObject McicadaName;
	public GameObject ButterflyName;

	int be = 0;
	int la = 0;
	int ac = 0;
	int mc = 0;
	int bu = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void BeName(){
		this.be += 1;
		BeetleName.GetComponent<Text> ().text = "カブトムシ　" + this.be;
	}

	public void LaName(){
		this.la += 1;
		LadybugName.GetComponent<Text> ().text = "テントウムシ　" + this.la;
	}

	public void AcName(){
		this.ac += 1;
		AcicadaName.GetComponent<Text> ().text = "アブラゼミ　" + this.ac;
	}

	public void McName(){
		this.mc += 1;
		McicadaName.GetComponent<Text> ().text = "ミンミンゼミ　" + this.mc;
	}

	public void BuName(){
		this.bu += 1;
		ButterflyName.GetComponent<Text> ().text = "カラスアゲハ　" + this.bu;
	}
}
