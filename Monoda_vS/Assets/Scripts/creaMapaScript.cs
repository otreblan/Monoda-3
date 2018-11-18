using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creaMapaScript : MonoBehaviour {

	public Rect tamanno;
	public spawnObj[] objs;

	Vector2 spawnPos;
	int spawnCanti;

	// Use this for initialization
	void Start () {
		foreach(spawnObj obj in objs)
		{
			spawnCanti = Mathf.CeilToInt(tamanno.height*tamanno.width/100f *obj.concentracion);
			for (int i = 0; i < spawnCanti; i++)
			{
				spawnPos = new Vector2(Random.Range(tamanno.xMin, tamanno.xMax),Random.Range(tamanno.yMin, tamanno.yMax));
				spawnPos -= tamanno.size/2;
				Instantiate(obj.cosa, (Vector3)spawnPos, Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}
[System.Serializable]
public struct spawnObj
{
	[Tooltip("Lo que quieras spawnear")]
	public GameObject cosa;
	[Tooltip("Cosas por cada 100 Unity meters al cuadrado")]
	public float concentracion;
	/* spawnObj(GameObject a)
	{
		b = a;
	}*/
}
