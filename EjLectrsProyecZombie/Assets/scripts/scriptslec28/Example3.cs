using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example3 : MonoBehaviour 
{


	void Start () 
	{
		//imprime un 1
		//print (INeedANumber(1));
		//imprime un 10 pero este 10 no se puede modificar
		//int val = INeedANumber(3) + INeedANumber (7);
		// es lo mismo que lo antyerior
		int val = INeedTwoNumbers(3,7);
		Debug.Log (val);
	}

//	int INeedANumber(int number)
//	{
//		// en el interrior de la funcion (3+1)+(7+1)
//		return number + 1;
//	}

//	int INeedTwoNumbers(int a, int b)
//	{
//		// en el interrior de la funcion (3+1)+(7+1)
//		return a + b;
//	}

	int INeedTwoNumbers(int a, float b)
	{
		// en el interrior de la funcion (3+1)+(7+1)
		return a * (int)b;
	}

	bool NumbersArethesame (int a, int b)
	{
//estas 2 formas son lock mismo
//		bool ret;
//		if (a == b) 
//		{
//			ret = true;
//		} 
//		else 
//		{
//			ret = false;
//		}
//		return ret;

		bool ret;
		if (a == b) 
		{
			return true;
		} 
		else 
		{
			return false;
		}
		return ret;
	}

	void Update () 
	{
		
	}
}
