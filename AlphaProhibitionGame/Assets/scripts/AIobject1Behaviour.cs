using UnityEngine;
using System.Collections;

public class AIobject1Behaviour : MonoBehaviour {
	//global variables
	Rigidbody2D rigi;
	float speed = 5.0f;
	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		keyboardMovement ();
	}

	private void keyboardMovement()
	{
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	}
}
