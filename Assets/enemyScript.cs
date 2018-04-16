using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		HealthbarScript.health -= 10f;
		GameControlScript.hearthealth -= 1;
	}

}
