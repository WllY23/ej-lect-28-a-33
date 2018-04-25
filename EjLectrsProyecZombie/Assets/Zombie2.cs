using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie2 : MonoBehaviour 
{
	public string name;
	public int brainsEaten;
	public int hitPoints;
	GameObject zombieMesh;

	void Start () 
	{
		string[] names = new string[] 
		{
			"stubbs","rob","white"	
		};
		for (int i = 0; i < names.Length; i++) 
		{
			Zombie z = new Zombie (names[i], Random.Range(10, 15));
			Debug.Log (z.name);
		}
	}
	public Zombie2 (string n, int hp) 
	{
		name = n;
		brainsEaten = 0;
		hitPoints = hp;
		zombieMesh = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		Vector3 pos = new Vector3 (Random.Range(-10, 10), 0,Random.Range(-10, 10));
		zombieMesh.transform.position = pos;
	}
}
