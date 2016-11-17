using UnityEngine;
using System.Collections;

public class reload : MonoBehaviour 
{
	public AudioSource objectReload;
	void Update () 
	{
		if (Input.GetMouseButtonUp(1))
		{
			objectReload.Play();
		}
	}
}
