using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource[] SoundEffect;
	/*private static SoundManager instance;
	public static SoundManager Instance
	{
		get {
			if (instance)
				instance = GameObject.FindObjectOfType (SoundManager);
		}
	}*/


	// Use this for initialization
	void Start () {
		SoundEffect [0].Play ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
