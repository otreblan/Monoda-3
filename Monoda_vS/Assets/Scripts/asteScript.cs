using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteScript : MonoBehaviour {
	

	public float rotVel = 1f;

	// Use this for initialization
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f,0f,Time.deltaTime*rotVel,Space.World);
	}
}
