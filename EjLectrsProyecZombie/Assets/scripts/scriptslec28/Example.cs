using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour 
{
	public static bool akey;
	public static bool wkey;
	public static bool skey;
	public static bool dkey;
	//public Vector3 pos;

	void Start () 
	{
		
	}
	

	Vector3 pos = Vector3.zero;

	void Update () 
	{
		bool akey = Input.GetKey (KeyCode.A);
		bool skey = Input.GetKey (KeyCode.S);
		bool dkey = Input.GetKey (KeyCode.D);
		bool wkey = Input.GetKey (KeyCode.W);
		transform.position = pos;

		if (akey)
		{
			pos.x=pos.x - 0.1f;
		}

		if (dkey)
		{
			pos.x=pos.x + 0.1f;
		}

		if (wkey)
		{
			pos.z=pos.z + 0.1f;
		}

		if (skey)
		{
			pos.z=pos.z - 0.1f;
		}
		transform.position = pos;
	}
}
