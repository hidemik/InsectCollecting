using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugGenerator : MonoBehaviour {

	public GameObject acicadaPrefab;
	public GameObject ladybugPrefab;
	public GameObject beetlePrefab;
	public GameObject mcicadaPrefab;
	public GameObject butterflyPrefab;

	public GameObject[] ButterflyArea;
	public GameObject[] Beetles;
	public GameObject[] ACicadaArea;
	public GameObject[] MCicadaArea;
	public GameObject[] LadybugArea;

	// Use this for initialization
	void Start (){
		for (int i = 0; i < 10; i++) {
			Generate ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		}

	//昆虫を生成
	public void Generate(){
		//どの昆虫を生成するか
		int bugs = Random.Range (1, 11);
		//カブトムシとセミの生成場所
		int i = Random.Range (1, 16);

			//abura cicada
		if (1 <= bugs && bugs <= 3) {
			GameObject abura = Instantiate (acicadaPrefab) as GameObject;
			abura.transform.position = new Vector3 (ACicadaArea [i].transform.position.x, ACicadaArea [i].transform.position.y, ACicadaArea [i].transform.position.z);
			abura.transform.rotation = ACicadaArea [i].transform.rotation;

		} else if (bugs == 4) {
			//ladybug
			//生成場所
			int b = Random.Range (0, 2);
			int c = Random.Range (1, 360);
			if (b == 0) {
				float tPosX = Random.Range (LadybugArea [b].transform.position.x, LadybugArea [b].transform.position.x + 4);
				float tPosZ = Random.Range (LadybugArea [b].transform.position.z, LadybugArea [b].transform.position.z + 3);
				GameObject ladybug = Instantiate (ladybugPrefab) as GameObject;
				ladybug.transform.position = new Vector3 (tPosX, LadybugArea [b].transform.position.y, tPosZ);
			} else if (b == 1) {
				float tPosX = Random.Range (LadybugArea [b].transform.position.x, LadybugArea [b].transform.position.x + 100);
				GameObject ladybug = Instantiate (ladybugPrefab) as GameObject;
				ladybug.transform.position = new Vector3 (tPosX, LadybugArea [b].transform.position.y, LadybugArea [b].transform.position.z);
			}

		} else if (5 <= bugs && bugs <= 6) {
			//beetle
			GameObject beetle = Instantiate (beetlePrefab) as GameObject;
			beetle.transform.position = new Vector3 (Beetles [i].transform.position.x, Beetles [i].transform.position.y, Beetles [i].transform.position.z);
			beetle.transform.rotation = Beetles [i].transform.rotation;

		} else if (7 <= bugs && bugs <= 8) {
			//minmin cicada
			GameObject minmin = Instantiate (mcicadaPrefab) as GameObject;
			minmin.transform.position = new Vector3 (MCicadaArea [i].transform.position.x, MCicadaArea [i].transform.position.y, MCicadaArea [i].transform.position.z);
			minmin.transform.rotation = MCicadaArea [i].transform.rotation;

		} else if (9 <= bugs && bugs <= 10) {
			//butterfly
			int a = Random.Range (0, 2);
			float nPosX = Random.Range (ButterflyArea [a].transform.position.x - 20, ButterflyArea [a].transform.position.x + 26);
			float nPosY = Random.Range (ButterflyArea [a].transform.position.y, ButterflyArea [a].transform.position.y + 15);
			float nPosZ = Random.Range (ButterflyArea [a].transform.position.z - 30, ButterflyArea [a].transform.position.z + 12);
			GameObject butterfly = Instantiate (butterflyPrefab) as GameObject;
			butterfly.transform.position = new Vector3 (nPosX, nPosY, nPosZ);
			butterfly.transform.Rotate (Random.Range (0, 46), Random.Range (0, 360), 0);
		}
}
}
