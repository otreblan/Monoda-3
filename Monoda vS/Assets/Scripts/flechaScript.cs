using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flechaScript : MonoBehaviour {

	public Transform flecha;
	public float vel = 1f;
	public float tempAngl;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//falta hacer que la flecha mantenga su rotación cuando no se está moviendo
		tempAngl = Mathf.Atan2(Input.GetAxis("Vertical"),Input.GetAxis("Horizontal"))*Mathf.Rad2Deg;
		flecha.rotation = Quaternion.Lerp(flecha.rotation, Quaternion.Euler(0f,0f,tempAngl),Time.deltaTime*vel);
	}
}
