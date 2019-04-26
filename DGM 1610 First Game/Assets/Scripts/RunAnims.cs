using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class RunAnims : MonoBehaviour
{
    private Animator anims;
    public Rigidbody rb;
    public float Speed;
    public float Veloc;

    void Start()
    {
        anims = GetComponent<Animator>();
        rb = GameObject.Find("Player").GetComponent<Rigidbody>();
    }

    void Update()
    {
        Veloc = rb.velocity.magnitude;
        //Debug.Log(Veloc);
        anims.SetFloat("Speed", Speed);
        anims.SetFloat("Velocity", Veloc);
    }
}