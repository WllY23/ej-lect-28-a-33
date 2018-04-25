using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour 
{
	public PrimitiveType primitiveType;
	GameObject obj;

	void Start () 
	{
		obj = GameObject.CreatePrimitive (primitiveType);
		if (myColor == colorType.red)
		{
			obj.GetComponent<Renderer> ().material.color = Color.red;
		}

		if (myColor == colorType.blue)
		{
			obj.GetComponent<Renderer> ().material.color = Color.blue;
		}

		if (myColor == colorType.green)
		{
			obj.GetComponent<Renderer> ().material.color = Color.green;
		}
	}

	public enum colorType
	{
		red, blue, green
	}

	public colorType myColor;
		
}
