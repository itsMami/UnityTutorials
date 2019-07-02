using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private CharacterController controller;
	public float moveSpeed = 6f,gravity = 20f,jumpForce = 8f;
	private Vector3 moveDir = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
		controller = GetComponent<CharacterController>();   
    }

    // Update is called once per frame
    void Update()
    {
		moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0))
			moveDir.y = jumpForce;
		moveDir.y -= gravity;
	}

	private void FixedUpdate()
	{
		controller.Move(moveDir * moveSpeed);
	}
}
