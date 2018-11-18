using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flechaScript : MonoBehaviour {

	// Use this for initialization
	public Transform flecha;
	public float vel = 1f;
	public float tempAngl;

	Vector2 oldPos;


    // Use this for initialization
    void Start () {
		oldPos = (Vector2)transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//falta hacer que la flecha mantenga su rotación cuando no se está moviendo
		//tempAngl = Mathf.Atan2(Input.GetAxis("Vertical"),Input.GetAxis("Horizontal"))*Mathf.Rad2Deg;
		oldPos = (Vector2)transform.position - oldPos;
		tempAngl = oldPos.magnitude > 0.01f ? Mathf.Atan2(oldPos.y, oldPos.x)* Mathf.Rad2Deg : tempAngl;
		
		flecha.rotation = Quaternion.Lerp(flecha.rotation, Quaternion.Euler(0f,0f,tempAngl),Time.deltaTime*vel);

		oldPos = (Vector2)transform.position;
	}
}
