using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Members : MonoBehaviour
{
	void Start ()
	{
		Members m= new Members();
		m.FirstFunction ();
	}

	void Update () 
	{
		
	}

	public void FirstFunction()
	{
		print ("First function");
	}
}
