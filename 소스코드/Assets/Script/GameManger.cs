using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour {
	public AudioSource[] SoundEffect;
	public GameObject Phone_obj1,Phone_obj2,Sagam_face,door,Sagam;
	public Text PaneltScore, PanaltyScore,plus;
	int score,ct;
	int function1=1,function2=1, Score;
	public bool OpenDoorCheck,flag,flag2;

	private static GameManger instance;
	public static GameManger Instance {
		get {
			if (instance == null) {
				instance = FindObjectOfType (typeof(GameManger)) as GameManger;
				if (instance == null) {
					Debug.LogError ("Error");
				}
			}
			return instance;
		}
	}


	void Start () {
		OpenDoorCheck = false;
		//StartCoroutine (ScoreUp ());	
		Sagam_face.SetActive (false);
		StartCoroutine (sagam());
	}

	void Update () {
		if (score >= 25 && ct!=0) {
			PlayerPrefs.SetInt("totalScore",Score);
			Application.LoadLevel ("finish");
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			function1 += 1;
			if (function1 == 1) {
				Phone_obj1.SetActive (false);
			}
			if (function1 == 2) {
				Phone_obj1.SetActive (true);
				StartCoroutine (ScoreUp1 ());
				function1 = 0;

			}
		}
			//yield return new WaitForSeconds (2.0f);
		if (Input.GetKeyDown (KeyCode.R)) {
				function2 += 1;
				if (function2 == 1) {
					Phone_obj2.SetActive (false);
				}
				if (function2 == 2) {
					Phone_obj2.SetActive (true);
					StartCoroutine (ScoreUp2 ());
					function2 = 0;

				}
		}

	}
	IEnumerator sagam(){
		flag = false;
		flag2 = false;
		ct = 0;
		yield return new WaitForSeconds (1f);
		int rnd = Random.Range (0, 9);
		if (rnd < 3 && OpenDoorCheck == false) {
			Sagam_face.SetActive (true);
			if (Score <= 50)
				yield return new WaitForSeconds (2f);
			else if(Score <= 100)
				yield return new WaitForSeconds (1f);
			else
				yield return new WaitForSeconds (0.5f);
			if (function1 != 1) {
				flag = true;
				Sagam_face.SetActive (false);
				door.transform.Rotate (new Vector3 (0, 90, 0));
				yield return new WaitForSeconds (1f);

				Sagam.SetActive (true);
				if (function2 != 1) {
					score += 15;
					PanaltyScore.text = "" + score;
					plus.text = "+" + 15;
					flag2 = true;
				} else {
					score += 10;
					PanaltyScore.text = "" + score;
					plus.text = "+" + 10;
				}
				yield return new WaitForSeconds (1f);
				door.transform.Rotate (new Vector3 (0, -90, 0));
				plus.text = null;
				yield return new WaitForSeconds (2f);
				Sagam.SetActive (false);
				ct++;

			}
			if (function2 != 1 && flag2!=true) {
				score += 5;
				PanaltyScore.text = "" + score;
			
				yield return new WaitForSeconds (1.5f);

				Sagam_face.SetActive (false);

				if (flag==false) {
					door.transform.Rotate (new Vector3 (0, 90, 0));
					yield return new WaitForSeconds (1f);
					Sagam.SetActive (true);
					plus.text = "+" + 5;
					yield return new WaitForSeconds (1f);
					door.transform.Rotate (new Vector3 (0, -90, 0));
					plus.text = null ;
					yield return new WaitForSeconds (2f);
					Sagam.SetActive (false);

				}
			}
			ct++;
			yield return new WaitForSeconds (2f);
			Sagam_face.SetActive (false);
		}
		StartCoroutine (sagam());
	}

	IEnumerator ScoreUp1 ()
	{
		yield return new WaitForSeconds (1f);
		if (function1 !=1) {
			Score += 1; 
			PaneltScore.text = "" + Score; 
			StartCoroutine (ScoreUp1 ());
		} 
	}

	IEnumerator ScoreUp2 ()
		{
			yield return new WaitForSeconds (3f);
			if (function2 !=1) {
				Score += 2; 
				PaneltScore.text = "" + Score; 
				StartCoroutine (ScoreUp2 ());
			} 
		}


}
