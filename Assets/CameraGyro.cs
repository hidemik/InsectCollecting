using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGyro : MonoBehaviour {

	void Start (){
		Input.gyro.enabled = true;
	}

	void Update (){
		Quaternion attitude = Input.gyro.attitude;
		attitude.x *= -1;
		attitude.y *= -1;
		transform.localRotation = Quaternion.Euler(90, 0, 0) * attitude;
	}
}