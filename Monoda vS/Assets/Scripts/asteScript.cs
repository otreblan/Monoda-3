using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteScript : MonoBehaviour {
	
	public plaScript pla;
	public float rotVel = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f,0f,Time.deltaTime*rotVel,Space.World);
	}
	/// <summary>
	/// OnMouseDown is called when the user has pressed the mouse button while
	/// over the GUIElement or Collider.
	/// </summary>
	void OnMouseDown()
	{
		pla.Aste += 1;
	}
}
