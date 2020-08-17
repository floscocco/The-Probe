using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;


public class CharacterMovement : MonoBehaviour 
{
    float moveSpeed;
    public float walkSpeed = 4f;
    public float runSpeed = 6f;
    public float jumpSpeed = 20f;
    public float gravity = 6f;

    Vector3 moveDirection;

    CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(moveX, 0, moveZ);
            moveDirection = transform.TransformDirection(moveDirection);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = runSpeed;
            }
            else
            {
                moveSpeed = walkSpeed;
            }

            moveDirection *= moveSpeed;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                moveDirection.y += jumpSpeed;
            }
        }

        moveDirection.y -= gravity;
        controller.Move(moveDirection * Time.deltaTime);
    }

    #region thirdperson
    // //CharacterController cc;
    // public Transform cam;
    // public float moveSpeed = 2f;
    // public float maxSpeed =5f;
    // public float jumpForce = 2f;
    // public float yVel = 0f;
    // public float gravity = 15f;

    // private Vector3 moveInput;
    // private Vector3 moveVelocity;

    // private Character facade;
    // private Rigidbody _rigidbody;
    // private Camera mainCamera;
    // private CharacterWeapons _currentWeapon;

    //// public Vector3 offset = new Vector3(0, 0, 10f);

    // //float xRotation = 45f;
    // //float yRotation = 0f;





    // private void Awake()
    // {
    //     facade = GetComponent<Character>();
    //     _rigidbody = GetComponent<Rigidbody>();
    //   //  cc = GetComponent<CharacterController>();
    //     mainCamera = FindObjectOfType<Camera>();

    // }

    // public void Update()
    // {
    //     moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
    //     moveVelocity = moveInput * moveSpeed;

    //     Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
    //     Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
    //     float rayLength;

    //     if(groundPlane.Raycast(cameraRay, out rayLength))
    //     {
    //         Vector3 pointToLook = cameraRay.GetPoint(rayLength);
    //         Debug.DrawLine(cameraRay.origin, pointToLook, Color.blue);
    //         transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));

    //     }





    //     //facade.Move(_rigidbody, direction, walkingForce, ForceMode.Force);

    // }

    // private void FixedUpdate()
    // {
    //     _rigidbody.velocity = moveVelocity;
    // }


    #endregion



}
