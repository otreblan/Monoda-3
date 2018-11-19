using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaScript : MonoBehaviour {

	public enum faction {Neutral, Fienel, Afeiz};
	public faction fac;
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
			//print("vida"+vida);
			//print(value);
			if (vida < 0f)
			{
				Destroy(this.gameObject);
			}
			vida = value < vidaMax ? value : vidaMax;
		}
	}
	float vida;

	

	// Use this for initialization
	void Start () {
		Vida = vidaInicial;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
