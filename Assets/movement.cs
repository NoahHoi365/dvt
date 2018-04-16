using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour {

float dirX, dirY;
public float moveSpeed = 5f;
Rigidbody2D rb;

	void Start(){
		rb = GetComponent<Rigidbody2D>();
	}
	void Update(){
		dirX = Input.GetAxis ("Horizontal");
		dirY = Input.GetAxis ("Vertical");

	}
	void FixedUpdate(){
		rb.velocity = new Vector2 (dirX * moveSpeed, dirY * moveSpeed);
	}
}
