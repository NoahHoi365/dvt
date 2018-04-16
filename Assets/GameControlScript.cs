using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour {

	public GameObject life1, life2, life3;
	public static int hearthealth;

	void Start(){
		hearthealth = 3;
		life1.gameObject.SetActive (true);
		life2.gameObject.SetActive (true);
		life3.gameObject.SetActive (true);
	}

	void Update(){
		if (hearthealth > 3)
			hearthealth = 3;

		switch (hearthealth) {
		case 3:
			life1.gameObject.SetActive (true);
			life2.gameObject.SetActive (true);
			life3.gameObject.SetActive (true);
			break;

		case 2:
			life1.gameObject.SetActive (true);
			life2.gameObject.SetActive (true);
			life3.gameObject.SetActive (false);
			break;

		case 1:
			life1.gameObject.SetActive (true);
			life2.gameObject.SetActive (false);
			life3.gameObject.SetActive (false);
			gameObject.GetComponent<AudioSource> ().Play ();
			break;

		case 0:
			life1.gameObject.SetActive (false);
			life2.gameObject.SetActive (false);
			life3.gameObject.SetActive (false);
			ScoreScript.scoreValue = 0;	
			break;
		}
	}
}