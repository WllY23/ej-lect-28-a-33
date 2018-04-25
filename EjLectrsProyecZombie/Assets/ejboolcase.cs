using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejboolcase : MonoBehaviour 
{
//	bool b = true;
	int i = 3;

	void Start () 
	{
//			switch (b)
//			{
//			case true:  Debug.Log ("got true "); break;
//			case false: Debug.Log ("got false"); break;
//			}
		switch (i)
		{
		case 0:
			Debug.Log ("i es igual a cero");
			break;
		case 1:
			Debug.Log ("i es igual a uno");
			break;
		case 2:
			Debug.Log ("i es igual a dos");
			break;
		default:
			Debug.Log ("cualquier otro numero");
			break;
		}
	}

	void Update () 
	{
		
	}
}
