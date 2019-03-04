using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
    private CharacterController controller;
    public UnityEvent OnGrounded, OffGrounded;

    public MoveBase CharacterMover;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded) {
            OnGrounded.Invoke();
        } else {
            OffGrounded.Invoke();
        }

        CharacterMover.Move(controller);


    }
}
