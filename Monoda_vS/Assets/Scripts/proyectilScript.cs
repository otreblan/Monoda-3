using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectilScript : MonoBehaviour {

	public float fuerza= 1f;
	float angle;
	public GameObject proyectil;

	GameObject proyectil2;

	//flechaScript direccion;
	flechaScript direccion;
	// Use this for initialization
	void Start () {
		direccion = this.gameObject.GetComponent<flechaScript>();
	}
	
	// Update is called once per frame
	void Update () {
		angle = direccion.tempAngl;
		if (Input.GetButton("Fire1"))
		{
			proyectil2 = Instantiate(proyectil, transform.position, Quaternion.Euler(0f,0f,angle));
			proyectil2.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right*fuerza);
		}
	}
}
