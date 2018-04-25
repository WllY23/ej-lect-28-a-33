using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example5pag31 : MonoBehaviour 
{

	public int numBoxes = 10;
	public GameObject[] boxes;
	public float spacing;
	public int id;


	void Start () 
	{
		boxes = new GameObject[numBoxes];
		for (int i = 0; i < numBoxes; i++)
		{
			GameObject box = GameObject.CreatePrimitive (PrimitiveType.Cube);
			box.AddComponent<Monster> ();//agrega el componente!
			//box.AddComponent ("Monster");
			Monster m = box.GetComponent ("Monster") as Monster;
			m.id = i;
			m.spacing = spacing;
			boxes [i] = box;
		}
	}

	void Update () 
	{
		int i = 0;
		foreach (GameObject go in boxes)
		{
			//time.fixedtime es un relog que empieza a corer al emprezar el juego
			float wave = Mathf.Sin (Time.fixedTime + id);
		//	go.transform.position = new Vector3 (id * spacing, wave, 0);
			transform.position = new Vector3 (id * spacing, wave, 0);
			i++;
			Debug.Log (i);
		}
	}
}

