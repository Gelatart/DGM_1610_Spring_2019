using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class RunAnims : MonoBehaviour
{
    public Animator anims;
    public Rigidbody rb;
    public float Speed;
    public float Veloc;
	private Vector3 pastLocation;

    void Start()
    {
        //anims = GetComponent<Animator>();
        rb = GameObject.Find("Player").GetComponent<Rigidbody>();
		pastLocation = rb.position;
    }

    void Update()
    {
		//formerly if(pastLocation == rb.position)
		if(Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) {
			//anims.SetFloat("Velocity", 1);
			Debug.Log("We are moving");
			anims.SetTrigger("Move");			
		} else {
			Debug.Log("We are idle");
			//anims.SetFloat("Velocity", 0);
			anims.SetTrigger("Idle");
		}
        Veloc = rb.velocity.magnitude;
        //Debug.Log(Veloc);
        anims.SetFloat("Speed", Speed);
        anims.SetFloat("Velocity", Veloc);
    }
}