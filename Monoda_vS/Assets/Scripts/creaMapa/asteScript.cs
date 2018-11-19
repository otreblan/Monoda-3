using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class asteScript : MonoBehaviour {
	

	public float rotVel = 1f;

	Rigidbody2D rigi;

	vidaScript vidaScr;

	// Use this for initialization
	// Update is called once per frame
	void Start () {
		//transform.Rotate(0f,0f,Time.deltaTime*rotVel,Space.World);
		rigi = GetComponent<Rigidbody2D>();
		vidaScr = GetComponent<vidaScript>();
		vidaScr.vidaMax = rigi.mass;
		vidaScr.vidaInicial = vidaScr.vidaMax;

		vidaScr = null;
		//rigi.AddTorque(rotVel);
	}
	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		rigi.AddTorque(rotVel);
	}
}
