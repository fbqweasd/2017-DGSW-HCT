using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCilck()
	{
		Application.LoadLevel ("zzz");
	}

	public void help()
	{
		Application.LoadLevel ("Game_howtoplay");
	}
}
