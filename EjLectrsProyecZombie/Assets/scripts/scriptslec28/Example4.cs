using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example4 : MonoBehaviour 
{
	float f = 0;
	void Start () 
	{
		
	}

	void Update () 
	{
		f += 0.25f;
		print (f);
	//	transform.position += Movemen(0.2f);
	}

	Vector3 Movemen()
	{
		Vector3 vec = Vector3.zero;

		return new Vector3 (0.1f, 0.2f, 0.3f);
	}
}
