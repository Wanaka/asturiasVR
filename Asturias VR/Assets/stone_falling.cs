using UnityEngine;
using System.Collections;

public class stone_falling : MonoBehaviour {

private AudioSource audio;

    void Start(){
            audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
    	audio.Play();  
    }
}
