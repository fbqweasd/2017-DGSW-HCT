using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {

	bool n = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate (Vector3.forward * 1f * Time.deltaTime);
	}

	void OnMouseDown()
	{
		if (n == false) {
			transform.Rotate (new Vector3 (0, 90, 0));
			GameManger.Instance.OpenDoorCheck = true;
			n = true;
		} else {
			transform.Rotate (new Vector3 (0, -90, 0));
			GameManger.Instance.OpenDoorCheck = false;
			n = false;
		}
	}


}
