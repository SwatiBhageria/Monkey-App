using UnityEngine;
using System.Collections;

public class ScrollScript : MonoBehaviour {

	public float speed = 0;
	public static ScrollScript current;
	
	float pos = 0;

	void start () {
				current = this;
		}

void Update () {

		pos += speed;
		if (pos > 1f)
		pos -= 1f;

				GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, pos);

} 

	}