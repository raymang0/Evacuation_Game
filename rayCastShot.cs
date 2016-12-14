using UnityEngine;
using System.Collections;

public class rayCastShot : MonoBehaviour {

	LineRenderer line1;
	public float RayCastHitZ = 5.0f;

	void Start(){
		line1 = gameObject.GetComponent<LineRenderer>();
		line1.enabled = false;

	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetButtonDown ("Fire1")) {
			StopCoroutine("FireLaser");
			StartCoroutine("FireLaser");


		}

	}

	IEnumerator FireLaser(){
		line1.enabled = true;

		while (Input.GetButtonDown ("Fire1")) {
			Ray ray = new Ray(transform.position, transform.right*-1);
			RaycastHit hit;

	//		if(Physics.Raycast(ray, out hit, 100))
	//		{
				line1.SetPosition (0, ray.origin);
	//		}
	//		else
	//		{
				line1.SetPosition (1, ray.GetPoint(100));
	//		}
			if(Physics.Raycast(ray, out hit, 100)){
				hit.transform.SendMessage("HitByRay");
			}
			yield return null;
		}

		line1.enabled = false;
	}
}
