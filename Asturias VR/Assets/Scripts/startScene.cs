﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class startScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnStartGame(){

		//load asturias scene
		SceneManager.LoadScene("asturias_scene");
	}
}




  
