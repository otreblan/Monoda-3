using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaScript : MonoBehaviour {

	public float vidaMax;
	public float vidaInicial;
	public float Vida
	{
		get
		{
			return vida;
		}
		set
		{
			if (vida <= 0f)
			{
				//destruir
			}
			vida = value < vidaMax ? value : vidaMax;
		}
	}
	float vida;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
