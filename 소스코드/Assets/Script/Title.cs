using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour {
	public Texture2D icon =null;
	public static string test = "아무키나 입력";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown)
			Application.LoadLevel ("main_scene");
	}
	void OnGUI()
	{
		
		GUI.Label (new Rect (Screen.width / 2, 128, 128, 32),test);
	}
}
