using UnityEngine;
using System.Collections;

public class cloud_movement : MonoBehaviour {


 public static float movespeed = Random.Range(-0.2f, 0.2f);

 public Vector3 userDirection = Vector3.left;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
	}
}


    