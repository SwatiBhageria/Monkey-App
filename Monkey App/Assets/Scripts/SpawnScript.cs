using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
	
	public GameObject[] obj;
	public Vector3 pos = new Vector3(0,-10,0);
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public float size = 1.0f;
	private Vector3 dir = Vector3.up;
	

	void Start () {
		StartCoroutine(Spawn());
	}

	IEnumerator Spawn() {
				while (true) 
			Instantiate (obj [Random.Range (0, obj.Length)], pos, Quaternion.identity);
		pos = dir * size;
		yield return new WaitForSeconds (Random.Range (3,4));
				}
		}