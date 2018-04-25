using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
	public string name;
	public int brainsEaten;
	public int hitPoints;
	GameObject zombieMesh;

	void Start () 
	{// todas las variables de zombies se proporcionan en un metodo y va separadas por un punto y coma
//		Zombie rob = new Zombie ();
//		rob.name = "Zombie";
//		rob.hitPoints = 10;
//		rob.brainsEaten = 0;
//		Zombie rob = new Zombie () 
//		{
//			name = "Zombie",
//			brainsEaten = 0,
//			hitPoints = 10
//		};
		// contructor de clase 
//		Zombie rob = new Zombie ("rob", 10);
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
		
	public Zombie (string n, int hp) 
	{
		name = n;
		brainsEaten = 0;
		hitPoints = hp;
		zombieMesh = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		Vector3 pos = new Vector3 (Random.Range(-10, 10), 0,Random.Range(-10, 10));
		//pos.x = Random.Range (-10, 10);
		//pos.y = 0f;//opcional
		//pos.z = Random.Range(-10,10);
		zombieMesh.transform.position = pos;
	}
		
	void Update () 
	{
		
	}
}
