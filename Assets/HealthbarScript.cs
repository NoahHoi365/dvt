using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarScript : MonoBehaviour {

Image Healthbar;
float maxHealth = 30f;
public static float health;

void Start(){
	Healthbar = GetComponent<Image> ();
	health = maxHealth;
}
	
	void Update(){
		if (health > 30)
			health = 30;
		Healthbar.fillAmount = health / maxHealth;
	}
	
}
