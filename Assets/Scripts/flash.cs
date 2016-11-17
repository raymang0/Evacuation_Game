using UnityEngine;
using System.Collections;

public class flash : MonoBehaviour 
{
	public Animation animatedObject;
	void Update () 
	{
		if (Input.GetMouseButtonDown(0))
		{
			animatedObject.Blend("flash");
		}

		if (Input.GetMouseButtonUp(0))
		{
			animatedObject.Stop("flash");
			animatedObject.Play("stopFlash");
		}
	}
}
