using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2 : MonoBehaviour 
{

	void Start ()
	{
		print ("impresion 1 - " + ImANumber());
		Debug.Log ("impresion 2 - " + (ImANumber() + ImANumber()));
	}

	int ImANumber()
	{
		return 3;
	}

	void Update () 
	{
		
	}
}
