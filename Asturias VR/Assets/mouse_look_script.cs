using UnityEngine;
using System.Collections;

public class mouse_look_script : MonoBehaviour {

	public float lookSens = 5f;
	public float xRot;
	public float yRot;

	GameObject character;

	// Use this for initialization
	void Start () {
		character = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		xRot -= Input.GetAxis("Mouse Y") *lookSens;
		yRot += Input.GetAxis("Mouse X") *lookSens;

		//makes the mouse stop on y axis when it goes to far up and down
		xRot = Mathf.Clamp(xRot, -90, 90);
		character.transform.rotation = Quaternion.Euler(xRot, yRot, 0);

	}

}


/*
using UnityEngine;
using System.Collections;

public class mouse_look_script : MonoBehaviour {

	Vector2 mouseLook;
	Vector2 smoothV;
	public float sensetivity = 5.0f;
	public float smoothing =2.0f;

	 GameObject character;
	// Use this for initialization
	void Start () {
		character = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

		md = Vector2.Scale(md, new Vector2(sensetivity * smoothing, sensetivity * smoothing));
		smoothV.x = Mathf.Lerp(smoothV.x, md.x, 0.5f / smoothing);
		smoothV.y = Mathf.Lerp(smoothV.y, md.y, 0.5f / smoothing);
		mouseLook+= smoothV;


		transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
		character.transform.localRotation = Quaternion.Euler(mouseLook.x, character.transform.up);
	}
}

*/
