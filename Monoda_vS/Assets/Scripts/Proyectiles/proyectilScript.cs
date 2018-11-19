using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proyectilScript : MonoBehaviour {

	[Tooltip("Velocidad del proyectil en UnityUnits/sec")]
	public float velocidad = 1f;
	
	[Tooltip("El proyectil a lanzar")]
	public GameObject proyectil;
	[Tooltip("Balas por minuto")]
	public float rpm = 60f;
	float angle;
	GameObject proyectil2;

	Quaternion QuaterAngle;

	//flechaScript direccion;
	flechaScript direccion;
	// Use this for initialization
	void Start () {
		direccion = GetComponent<flechaScript>();
		StartCoroutine(shoot());
	}
	
	// Update is called once per frame
	void Update () {
		//angle = direccion.tempAngl;
		
	}
	IEnumerator shoot()
	{
		while(true)
		{
			
			yield return new WaitUntil(()=> Input.GetButton("Fire1"));
			
			//angle += Random.Range(-5,6);
			QuaterAngle = direccion.flechaAngl * Quaternion.Euler(0f,0f,Random.Range(-5,6));
			proyectil2 = Instantiate(proyectil, transform.position + QuaterAngle*Vector2.right, QuaterAngle);
			//proyectil2.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.right*fuerza);
			proyectil2.GetComponent<Rigidbody2D>().velocity = QuaterAngle*Vector2.right*velocidad;
			GameObject.Destroy(proyectil2, 5f);
			
			yield return new WaitForSeconds(60f/rpm);
		}
	}
}
