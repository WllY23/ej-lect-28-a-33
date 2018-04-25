using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejmovimiento : MonoBehaviour
{
	Vector3 pos = Vector3.zero;
	public float speed; // en unity se cambia a 0.2
	void Start ()
	{
		
	}

	void Update () 
	{
		//print (Input.GetKey(KeyCode.A));	
		transform.position += Movement(0.5f);

	}

	Vector3 Movement (float dist)
	{
		Vector3 vec = Vector3.zero;
		if(Input.GetKey(KeyCode.A))
		{
			vec.x -= dist;
		}
		if(Input.GetKey(KeyCode.D))
		{
			vec.x += dist;
		}
		if(Input.GetKey(KeyCode.W))
		{
			vec.z += dist;
		}
		if(Input.GetKey(KeyCode.S))
		{
			vec.z -= dist;
		}
		return vec;
	}
}
