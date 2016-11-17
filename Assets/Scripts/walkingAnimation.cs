using UnityEngine;
using System.Collections;

public class walkingAnimation : MonoBehaviour 
{
	public Animation animatedObject;
	public AudioSource objectSound;

	void Update () 
	{
		if ((Input.GetKeyDown("w"))||(Input.GetKeyDown("a"))||(Input.GetKeyDown("s"))||(Input.GetKeyDown("d")))
		{
			animatedObject.Blend("walkingAnimation");
		}

		if ((Input.GetKeyUp("w"))||(Input.GetKeyUp("a"))||(Input.GetKeyUp("s"))||(Input.GetKeyUp("d"))) 
		{
			animatedObject.Stop("walkingAnimation");
		}

		if (Input.GetMouseButtonDown(0))
		{
			animatedObject.Blend("recoilAnimation");
			objectSound.Play();
		}

		if (Input.GetMouseButtonUp(0))
		{
			animatedObject.Stop("recoilAnimation");
			objectSound.Stop();
		}

		if (Input.GetKeyDown("space"))
			animatedObject.Blend("jumpAnimation");

		if (Input.GetMouseButtonUp(1))
		{
			animatedObject.Blend("reloadAnimation");
		}
	}
}
