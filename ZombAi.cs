using UnityEngine;
using System.Collections;

public class ZombAi : MonoBehaviour {
	public float walkSpeed = 20.0F;
	public float jumpSpeed = 20.0F;
	public float runSpeed = 20.0F;
	public float gravity = 120.0F;
	public Transform target;
	public float speed = 220.0F;
	public Animator anim;
	
	private Vector3 moveDirection = Vector3.zero;
	private CharacterController controller;
	private Collider col;
	
	void Start()
	{
		controller = GetComponent<CharacterController>();
		col = GetComponent<CapsuleCollider>();
		anim = GetComponent<Animator> ();
	}



	void Update()
	{

		    
			Vector3 targetDir = target.position - transform.position;
			float step = speed * Time.deltaTime;
			float distance = Vector3.Distance (target.position, transform.position);
			targetDir.y = 0;
			Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, step, 0.0F);
			transform.rotation = Quaternion.LookRotation (newDir);
			if (distance > 3) {
			anim.SetFloat("Speed", 0);

			Debug.DrawRay (transform.position, newDir, Color.red);
			transform.rotation = Quaternion.LookRotation (newDir);

			newDir.y -= gravity * Time.deltaTime;
			controller.Move (newDir * Time.deltaTime*2.0F);

		} else {
			anim.SetFloat("Speed", 1);
		}
	
	}
	void HitByRay(){
		anim.SetFloat ("Dead", 2);
	}
}