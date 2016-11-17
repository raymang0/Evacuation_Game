using UnityEngine;
using System.Collections;

public class ZombAi : MonoBehaviour {
	public float walkSpeed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float runSpeed = 8.0F;
	public float gravity = 20.0F;
	public Transform target;
	public float speed = 2;
	
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	
	void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update()
	{
	//	if (controller.isGrounded)
	//	{
	//		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	//		moveDirection = transform.TransformDirection(moveDirection);
	//		moveDirection *= walkSpeed; 

			Vector3 targetDir = target.position - transform.position;
			float step = speed * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			Debug.DrawRay(transform.position, newDir, Color.red);
			transform.rotation = Quaternion.LookRotation(newDir);

			newDir.y -= gravity * Time.deltaTime;
			controller.Move(newDir * Time.deltaTime);

			//transform.Translate(Vector3.forward * Time.deltaTime);
	//	}
	//	moveDirection.y -= gravity * Time.deltaTime;


	}
}
