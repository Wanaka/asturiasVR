using UnityEngine;
using System.Collections;

public class stone_falling : MonoBehaviour {

private drop_rocks droprocks;
private AudioSource audio;
private bool playFunction = true;
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

        if(playFunction){
            audio.Play();  
            //Instantiate the rocks from the other script
            droprocks.Inst();
            playFunction = false;
        }
    }
}
//functionen ska bara köra EN gång. efter det ska den dö.
//testa bool--> börja med true och efter den körs ska den bli false och inte kunna köra igen.