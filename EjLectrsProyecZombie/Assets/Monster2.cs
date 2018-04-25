using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster2 : MonoBehaviour
{

	public enum MonsterState
	{
		standing, wandering, chasing, attacking
	}

	public MonsterState mState;

	void Start () 
	{
		mState = MonsterState.standing;
//		mState = MonsterState.attacking;
//		int number = (int)mState;
//		Debug.Log (number);
	}

	void Update ()
	{
		if(mState == MonsterState.standing)
		{
			Debug.Log ("stading monster is stadong.");
		}

		if(mState == MonsterState.wandering)
		{
			Debug.Log ("wandering monster is wandering.");
		}

		if(mState == MonsterState.chasing)
		{
			Debug.Log ("chasing monster is chasing.");
		}

		if(mState == MonsterState.attacking)
		{
			Debug.Log ("attacking monster is attacking.");
		}
	}

}
