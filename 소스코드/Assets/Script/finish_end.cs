using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finish_end : MonoBehaviour {

	public int result;
	public Text ScoreText;

	void Start () {
		result = PlayerPrefs.GetInt("totalScore");
		ScoreText.text = " " + result; 
	}
	
	// Update is called once per frame
	void Update () {
		//StartCoroutine (Scoar ());
	}

	/*IEnumerator Scoar(){
		butten.text = " " + result; 
	}*/
}
