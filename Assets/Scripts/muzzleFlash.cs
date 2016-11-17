using UnityEngine;
using System.Collections;

public class muzzleFlash : MonoBehaviour 
{
	public Animation animatedObject;
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			animatedObject.Blend("muzzleFlash");
		}

		if (Input.GetMouseButtonUp(0))
		{
			animatedObject.Stop("muzzleFlash");
			animatedObject.Play("stopMuzzle");
		}
	}
}

