using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
	public float spacing;
	public int id;
	void Start () 
	{
		Debug.Log ("Im alive!");
	}
	

	void Update ()
	{
		float wave = Mathf.Sin (Time.fixedTime + id);
		//	go.transform.position = new Vector3 (id * spacing, wave, 0);
		transform.position = new Vector3 (id * spacing, wave, 0);
	}
}
