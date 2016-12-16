using UnityEngine;
using System.Collections;

public class activateParticlesreStart : MonoBehaviour {

public Transform particles;
	// Use this for initialization
	void Start () {
		particles.GetComponent<ParticleSystem> ().enableEmission = false;
	}
	

	void OnTriggerEnter(Collider other) {
		particles.GetComponent<ParticleSystem> ().enableEmission = true;
    	
    }			
}
