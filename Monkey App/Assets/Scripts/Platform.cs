using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "Platform2")
		{
			Destroy(col.gameObject);
		}
	}
}
