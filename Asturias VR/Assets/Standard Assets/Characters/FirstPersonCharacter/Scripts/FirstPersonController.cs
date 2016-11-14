using UnityEngine;
using System.Collections;


public class FirstPersonController : MonoBehaviour {
    public float speed = 1.5F;
    public float jumpSpeed = 0F;
    public float gravity = 0.0F;
    private Vector3 moveDirection = Vector3.zero;

    public AudioSource audio;

    void Start(){
            audio = GetComponent<AudioSource>();
    }
    


    void Update() {
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded) {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        
        /*Playing sound*/
        if (Input.GetKey (KeyCode.W))
     {
         // ... and if the footsteps are not playing...
         if(!audio.isPlaying)
         {
             // ... play them.
             audio.Play();
         }
     }
         else
         {
             // Otherwise stop the footsteps.
             audio.Stop();            
     }








        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);


        float mouseInputX = Input.GetAxis("Mouse X");
        float mouseInputY = Input.GetAxis("Mouse Y");
         Vector3 lookhere = new Vector3(-mouseInputY, mouseInputX, 0);
         transform.Rotate(lookhere);
        
}
}