using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	[HideInInspector]public Transform Player;

	public static GameManager instance;
	// Use this for initialization
	void Start ()
	{
		instance = this;
		Player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
