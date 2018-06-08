using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameM : MonoBehaviour {
	
		public GameObject Phone_obj;
		public Text PaneltScorea;
		int function, Score;

		void Start () {
			//StartCoroutine (ScoreUp ());	
		}

		void Update () {
			if (Input.GetKeyDown (KeyCode.G)) {
				function +=1;
				if (function == 1) {
					Phone_obj.SetActive (false);
				}
				if (function ==2)
				{
					Phone_obj.SetActive (true);
					StartCoroutine (ScoreUp ());
					function = 0;

				}
				//yield return new WaitForSeconds (2.0f);
			}
		}



		IEnumerator ScoreUp()
		{
			yield return new WaitForSeconds (1f);
			if (function !=1) {
				Score += 1; 
				PaneltScorea.text = "" + Score; 
				StartCoroutine (ScoreUp ());
			} 
		}


	}
