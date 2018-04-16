using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col){
		GameControlScript.hearthealth += 1;
		HealthbarScript.health += 10f;
		ScoreScript.scoreValue += 10;
	}
}
