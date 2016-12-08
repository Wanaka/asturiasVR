using UnityEngine;
using System.Collections;

public class stone_falling : MonoBehaviour {

private drop_rocks droprocks;
private AudioSource audio;
//private bool hasEntered = false;

void Awake ()
    {
    	droprocks = GameObject.FindObjectOfType<drop_rocks>();
    }

    void Start(){
            audio = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other) {

		
    	audio.Play();  
    	//Instantiate the rocks from the other script
    	droprocks.Inst();
    	
    }
}
