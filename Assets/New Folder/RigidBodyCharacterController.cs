using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lecture29
{
    public class RigidBodyCharacterController : MonoBehaviour
    {
        Rigidbody rigidbody;
        Vector3 input;
        bool jump = false;

        float battahSpeed = 4f;
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
            // rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            rigidbody.mass = 1;
            // rigidbody.drag = 0.1f;
            // rigidbody.angularDrag = 0.06f;
            // rigidbody.useGravity = false;
            // rigidbody.isKinematic = true;
        }

        void Update() // Checking for input 
        {
            input = new Vector3(-Input.GetAxisRaw("Horizontal"),
                                0,
                                -Input.GetAxisRaw("Vertical"));
            input = input.normalized * battahSpeed;

            input.y = rigidbody.linearVelocity.y;

            if (Input.GetKeyUp(KeyCode.Space))
            {
                jump = true;
            }
        }

        void FixedUpdate()
        {
            // rigidbody.rotation = Quaternion.Euler(0, 90, 0);
            if (jump)
            {
                rigidbody.linearDamping = 0.5f;
                rigidbody.AddForce(Vector3.up * 10, ForceMode.Impulse);
                jump = false;
            }
            else
            {
                rigidbody.linearDamping = 0;
                rigidbody.linearVelocity = input;
            }
        }
    }
}