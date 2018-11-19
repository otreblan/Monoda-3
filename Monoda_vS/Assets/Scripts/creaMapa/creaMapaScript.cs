using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.CoreModule;

public class creaMapaScript : MonoBehaviour {

	public Rect tamanno;
	public spawnObj[] objs;

	Vector2 spawnPos;
	int spawnCanti;

	

	// Use this for initialization
	void Start () {
		List<GameObject> cosas = new List<GameObject>();
		foreach(spawnObj obj in objs)
		{
			spawnCanti = Mathf.CeilToInt(tamanno.height*tamanno.width/100f *obj.concentracion);
			GameObject spawnObj;
			float randomVal;

			for (int i = 0; i < spawnCanti; i++)
			{
				//posicion random
				spawnPos = new Vector2(Random.Range(tamanno.xMin, tamanno.xMax),Random.Range(tamanno.yMin, tamanno.yMax));
				spawnPos -= tamanno.size/2;
				//spawn
				spawnObj = Instantiate(obj.cosa, (Vector3)spawnPos, Quaternion.Euler(0f,0f,Random.Range(0f,360f)));
				cosas.Add(spawnObj);
				//random
				randomVal = obj.size.Evaluate(Random.value);
				//Tamanno random
				spawnObj.GetComponent<Transform>().localScale *= randomVal;
				//velocidad random
				spawnObj.GetComponent<asteScript>().rotVel /= randomVal * ((Random.value <= 0.5f) ? 1f : -1f);
			}
		}
		AsteControScript.astes = cosas.ToArray();
		cosas = null;
	}
	
	
}
[System.Serializable]
public struct spawnObj
{
	[Tooltip("Lo que quieras spawnear")]
	public GameObject cosa;
	[Tooltip("Cosas por cada 100 Unity meters al cuadrado")]
	public float concentracion;

	public AnimationCurve size;
	/* spawnObj(GameObject a)
	{
		b = a;
	}*/
}
