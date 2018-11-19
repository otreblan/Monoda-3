using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala1Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	/// <summary>
	/// Sent when another object enters a trigger collider attached to this
	/// object (2D physics only).
	/// </summary>
	/// <param name="other">The other Collider2D involved in this collision.</param>
	void OnTriggerEnter2D(Collider2D other)
	{
		switch (other.GetComponent<vidaScript>().fac)
		{
			case vidaScript.faction.Neutral:
				//Destroy(other.gameObject);
				other.GetComponent<vidaScript>().Vida -= 1f;
				Destroy(this.gameObject);
				break;
		}

	}
}
