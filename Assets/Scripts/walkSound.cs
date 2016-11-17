using UnityEngine;
using System.Collections;

public class walkSound : MonoBehaviour 
{
	public AudioSource objectWalk;
	void Update () 
	{
		if ((Input.GetKeyDown("w"))||(Input.GetKeyDown("a"))||(Input.GetKeyDown("s"))||(Input.GetKeyDown("d")))
		{
			objectWalk.Play();
		}

		if ((Input.GetKeyUp("w"))||(Input.GetKeyUp("a"))||(Input.GetKeyUp("s"))||(Input.GetKeyUp("d"))) 
		{
			objectWalk.Stop();
		}
	}
}
