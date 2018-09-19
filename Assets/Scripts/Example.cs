using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {

	public bool trueOrFalse;
	public float decimalNumber = 5.0f;
	public float speed = 1.0f;
	public int aWholeNumber = 20;
	public string firstName = "Lucas";
	public int playerHealth;

	public Color materialColor;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello world");
	}

	

	// Update is called once per frame
	void Update () {
		// We need this to spin so it will hit the player
		//transform.eulerAngles += new Vector3(0, speed, 0);

		// We want the cube to be hard to hit
		//transform.position += new Vector3(speed, 0, 0);

		//transform.Rotate(new Vector3(0, 0, speed));
		//transform.Rotate(new Vector3(speed, 0, 0));

		//transform.Rotate(Vector3.up, Space.World);

		//GetComponent<MeshRenderer>().material.color = materialColor;
	}

	public void Jump(float force) {
		GetComponent<Rigidbody>().AddForce(0, force, 0);
	} 

	public void Fade(float sliderValue) {
		materialColor.a = sliderValue;
		GetComponent<MeshRenderer>().material.color = materialColor;
	}
}
