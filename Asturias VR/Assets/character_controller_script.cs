using UnityEngine;
using System.Collections;

public class character_controller_script : MonoBehaviour {

public float speed = 1.0F;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis("Vertical") * speed;
		float straffe = Input.GetAxis("Horizontal") * speed;
		translation*= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate(straffe,0,translation);
		

	}
}
